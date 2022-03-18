using Devita.Enum;
using Devita.Helper;
using Devita.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class ProductController : Controller
    {
        private readonly DevitaContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(DevitaContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Include(x => x.ProductComments).Include(x => x.ProductImages).Include(x => x.ProductColors).Include(x => x.Category).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (product.PosterFile == null)
            {
                ModelState.AddModelError("PosterFile", "Poster image is required!");
                return View();
            }

            else
            {
                if (product.PosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("PosterFile", "PosterFile max size is 2MB!");
                    return View();
                }

                else if (product.PosterFile.ContentType != "image/jpeg" && product.PosterFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("PosterFile", "ContentType must be image/jpeg or image/png!");
                    return View();
                }

                ProductImage poster = new ProductImage
                {
                    Image = FileManager.Save(_env.WebRootPath, "uploads/products", product.PosterFile),
                    Product = product,
                    PosterStatus = true
                };
                _context.ProductImages.Add(poster);
                //product.ProductImages.Add(poster);
            }

            if (product.HoverPosterFile == null)
            {
                ModelState.AddModelError("HoverPosterFile", "Hover image is required!");
                return View();
            }

            else
            {
                if (product.HoverPosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("HoverPosterFile", "PosterFile max size is 2MB!");
                    return View();
                }

                else if (product.HoverPosterFile.ContentType != "image/jpeg" && product.HoverPosterFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("HoverPosterFile", "ContentType must be image/jpeg or image/png!");
                    return View();
                }

                ProductImage hover = new ProductImage
                {
                    Image = FileManager.Save(_env.WebRootPath, "uploads/products", product.HoverPosterFile),
                    Product = product,
                    PosterStatus = false
                };
                _context.ProductImages.Add(hover);
                //product.ProductImages.Add(hover);
            }

            if (product.ImageFiles != null)
            {
                foreach (var item in product.ImageFiles)
                {
                    if (item.Length > 2097152)
                    {
                        ModelState.AddModelError("ImageFiles", "ImageFile max size is 2MB");
                        return View();
                    }
                    if (item.ContentType != "image/jpeg" && item.ContentType != "image/png")
                    {
                        ModelState.AddModelError("ImageFiles", "ContentType must be image/jpeg or image/png");
                        return View();
                    }


                    ProductImage productImage = new ProductImage
                    {
                        Product = product,
                        Image = FileManager.Save(_env.WebRootPath, "uploads/products", item)
                    };

                    _context.ProductImages.Add(productImage);
                }
            }

            _context.Products.Add(product);

            var productColors = new List<ProductColor>();

            foreach (var colorId in product.Colors)
            {
                productColors.Add(new ProductColor
                {
                    ProductId = product.Id,
                    Color = (ColorProduct)colorId
                });
            }

            product.ProductColors = productColors;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Product product = _context.Products.Include(x => x.ProductComments).Include(x => x.ProductImages).Include(x => x.ProductColors).Include(x => x.Category).FirstOrDefault(x => x.Id == id);

            if(product==null)
            {
                return RedirectToAction("index", "error");
            }

            ViewBag.Categories = _context.Categories.ToList();

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {

            Product existProduct = _context.Products.Include(x => x.ProductImages).FirstOrDefault(x => x.Id == product.Id);

            if (existProduct == null)
            {
                return RedirectToAction("index", "error");
            }

            if (product.PosterFile != null)
            {
                if(product.PosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("PosterFile", "ImageFile max size is 2MB!");
                }

                else if(product.PosterFile.ContentType != "image/jpeg" && product.PosterFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("PosterFile", "ContentType must be image/jpeg or image/png");
                }
            }

            if (product.HoverPosterFile != null)
            {
                if (product.HoverPosterFile.Length > 2097152)
                {
                    ModelState.AddModelError("HoverPosterFile", "ImageFile max size is 2MB!");
                }

                else if (product.HoverPosterFile.ContentType != "image/jpeg" && product.HoverPosterFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("HoverPosterFile", "ContentType must be image/jpeg or image/png");
                }
            }


            if (product.ImageFiles != null)
            {

                foreach (var item in product.ImageFiles)
                {
                    if (item.Length > 2097152)
                    {
                        ModelState.AddModelError("ImageFiles", "ImageFile max size is 2MB!");
                        break;
                    }

                    else if (item.ContentType != "image/jpeg" && product.HoverPosterFile.ContentType != "image/png")
                    {
                        ModelState.AddModelError("ImageFiles", "ContentType must be image/jpeg or image/png");
                        break;
                    }
                }
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (product.PosterFile != null)
            {
                ProductImage currentImage = existProduct.ProductImages.FirstOrDefault(x => x.PosterStatus == true);

                if(currentImage==null)
                {
                    return RedirectToAction("index", "error");
                }

                _setProductImage(currentImage, product.PosterFile);
            }

            if(product.HoverPosterFile!=null)
            {
                ProductImage currentImage = existProduct.ProductImages.FirstOrDefault(x => x.PosterStatus == false);

                if(currentImage==null)
                {
                    return RedirectToAction("index", "error");
                }

                _setProductImage(currentImage, product.HoverPosterFile);
            }

            if (product.ImageFiles != null)
            {
                foreach (var imageItem in existProduct.ProductImages.Where(x => x.PosterStatus == null))
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/products", imageItem.Image);
                    _context.ProductImages.Remove(imageItem);
                }

                foreach (var imageFile in product.ImageFiles)
                {
                    ProductImage bookImage = new ProductImage
                    {
                        ProductId = product.Id,
                        PosterStatus = null,
                        Image = FileManager.Save(_env.WebRootPath, "uploads/products", imageFile)
                    };

                    _context.ProductImages.Add(bookImage);
                    //existBook.BookImages.Add(bookImage);
                }
            }
            _setProductData(existProduct, product);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Product product = _context.Products.Include(x => x.ProductComments).Include(x => x.ProductImages).Include(x => x.ProductColors).Include(x => x.Category).FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return RedirectToAction("index", "error");
            }

            ViewBag.Categories = _context.Categories.ToList();

            return View(product);
        }

        //[HttpPost]
        //public IActionResult Delete(Product product)
        //{
        //    Product existProduct = _context.Products.FirstOrDefault(x => x.Id == product.Id);

        //    if(existProduct == null)
        //    {
        //        return RedirectToAction("index", "error");
        //    }

        //    FileManager.Delete(_env.WebRootPath , "uploads/products" , existProduct.)


        //}

        private void _setProductImage(ProductImage image, IFormFile file)
        {
            string newFileName = FileManager.Save(_env.WebRootPath, "uploads/products", file);

            FileManager.Delete(_env.WebRootPath, "uploads/products", image.Image);
            image.Image = newFileName;
        }

        private void _setProductData(Product existProduct, Product product)
        {
            existProduct.Name = product.Name;
            existProduct.Description = product.Description;
            existProduct.CostPrice = product.CostPrice;
            existProduct.Category = product.Category;
            existProduct.SalePrice = product.SalePrice;
            existProduct.StockStatus = product.StockStatus;
            existProduct.IsBest = product.IsBest;
            existProduct.IsNew = product.IsNew;
            existProduct.IsFeatured = product.IsFeatured;
            existProduct.IsTopHeadphone = product.IsTopHeadphone;
            existProduct.IsTopRate = product.IsTopRate;
            existProduct.DiscountPercent = product.DiscountPercent;
        }

        public IActionResult Comments(int id)
        {
            List<ProductComment> comments = _context.ProductComments.Include(x => x.Product).Where(x => x.ProductId == id).ToList();
            return View(comments);
        }

        public IActionResult DeleteComment(int id)
        {
            ProductComment comment = _context.ProductComments.FirstOrDefault(x => x.Id == id);

            if (comment == null)
            {
                return RedirectToAction("index", "error");
            };

            _context.ProductComments.Remove(comment);
            _context.SaveChanges();

            return Ok();
        }

        public IActionResult InfoComment(int id)
        {
            ProductComment comment = _context.ProductComments.Include(x => x.Product).FirstOrDefault(x => x.Id == id);

            if (comment == null)
            {
                return RedirectToAction("index", "error");
            };

            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AcceptComment(int id)
        {
            ProductComment comment = _context.ProductComments.FirstOrDefault(x => x.Id == id);

            if (comment == null)
            {
                return RedirectToAction("index", "error");
            };

            comment.Status = true;
            comment.CommentStatus = true;

            _context.SaveChanges();

            return RedirectToAction("index");
            //return View();
        }

        //public IActionResult Delete(int id)
        //{
        //    Product product = _context.Products.
        //}
    }
}
