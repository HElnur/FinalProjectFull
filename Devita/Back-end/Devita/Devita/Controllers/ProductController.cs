using Devita.Models;
using Devita.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Controllers
{
    public class ProductController : Controller
    {
        private readonly DevitaContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ProductController(DevitaContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }



        public async Task<IActionResult> AddBasket(int prodId)
        {
            if (!_context.Products.Any(x => x.Id == prodId))
            {
                return NotFound();
            }

            BasketViewModel data = null;

            AppUser user = null;
            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);
            }

            if (user != null && user.IsAdmin == false)
            {
                BasketItem basketItem = _context.BasketItems.FirstOrDefault(x => x.AppUserId == user.Id && x.ProductId == prodId);

                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        ProductId = prodId,
                        Count = 1
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count++;
                }

                _context.SaveChanges();

                data = _getBasketItems(_context.BasketItems.Include(x => x.Product).ThenInclude(x => x.ProductImages).Where(x => x.AppUserId == user.Id).ToList());
            }
            else
            {
                List<CookieBasketItemViewModel> basketItems = new List<CookieBasketItemViewModel>();
                string existBasketItems = HttpContext.Request.Cookies["basketItemList"];

                if (existBasketItems != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<CookieBasketItemViewModel>>(existBasketItems);
                }

                CookieBasketItemViewModel item = basketItems.FirstOrDefault(x => x.ProductId == prodId);

                if (item == null)
                {
                    item = new CookieBasketItemViewModel
                    {
                        ProductId = prodId,
                        Count = 1
                    };
                    basketItems.Add(item);
                }
                else
                    item.Count++;

                var prodIdsStr = JsonConvert.SerializeObject(basketItems);

                HttpContext.Response.Cookies.Append("basketItemList", prodIdsStr);

                data = _getBasketItems(basketItems);
            }


            //return Ok(data);
            return RedirectToAction("index", "home");
        }

        public IActionResult Detail(int id)
        {
            ViewBag.ProductId = id;
            Product product = _context.Products
                .Include(x => x.ProductImages)
                .Include(x => x.ProductComments)
                .Include(x => x.Category).FirstOrDefault(x => x.Id == id);

            ProductDetailViewModel productDetailVM = new ProductDetailViewModel
            {
                Product = product,
                RelatedProduct = _context.Products
                .Include(x => x.ProductImages)
                .Where(x => x.CategoryId == product.CategoryId).OrderByDescending(x => x.Id).Take(5).ToList()
            };

            return View(productDetailVM);
        }

        public IActionResult Shop(int? categoryId, int page = 1, decimal? minPrice = null, decimal? maxPrice = null)
        {
            var products = _context.Products.Include(x => x.Category).Include(x => x.ProductImages).AsQueryable();



            if (categoryId != null)
            {
                products = products.Where(x => x.CategoryId == categoryId);
            }

            ViewBag.MinPrice = products.Min(x => x.SalePrice);
            ViewBag.MaxPrice = products.Max(x => x.SalePrice);

            if (minPrice != null && maxPrice != null)
            {
                products = products.Where(x => x.SalePrice >= minPrice && x.SalePrice <= maxPrice);
            }

            ViewBag.SelectedMinPrice = minPrice ?? ViewBag.MinPrice;
            ViewBag.SelectedMaxPrice = maxPrice ?? ViewBag.MaxPrice;


            ShopViewModel shopVM = new ShopViewModel
            {
                Categories = _context.Categories.Include(x => x.Products).ToList(),
                //Categories = _context.Categories.ToList(),
                Colors = _context.Colors.ToList(),
                PagenetedProduct = Pagenated<Product>.Create(products, page, 4)

            };
            return View(shopVM);
        }

        [HttpPost]
        public async Task<IActionResult> Comment(ProductComment comment)
        {
            Product product = await _context.Products
                .Include(x => x.ProductImages).Include(x => x.Category)
                .Include(x => x.ProductComments).FirstOrDefaultAsync(x => x.Id == comment.ProductId);

            if (product == null)
            {
                return RedirectToAction("index", "error");
            }

            ProductDetailViewModel prodDetailVM = new ProductDetailViewModel
            {
                Product = product,
                Comment = comment,
                RelatedProduct = _context.Products
                .Include(x => x.ProductImages)
                .Where(x => x.CategoryId == product.CategoryId)
                .OrderByDescending(x => x.Id).Take(5).ToList()
            };

            if (!ModelState.IsValid)
            {
                return View("Detail", prodDetailVM);
            }

            if (!_context.Products.Any(x => x.Id == comment.ProductId))
            {
                return View("Detail", prodDetailVM);
            }

            if (!User.Identity.IsAuthenticated)
            {
                if (string.IsNullOrWhiteSpace(comment.Email))
                {
                    return View("Detail", prodDetailVM);
                }

                if (string.IsNullOrWhiteSpace(comment.FullName))
                {
                    return View("Detail", prodDetailVM);
                }
            }

            else
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                comment.AppUserId = user.Id;
                comment.FullName = user.FullName;
                comment.Email = user.Email;
            }

            comment.Status = false;
            comment.CreateAt = DateTime.UtcNow.AddHours(4);
            _context.ProductComments.Add(comment);
            _context.SaveChanges();


            return RedirectToAction("detail", new { Id = comment.ProductId });


        }

        private BasketViewModel _getBasketItems(List<CookieBasketItemViewModel> cookieBasketItems)
        {
            BasketViewModel basket = new BasketViewModel
            {
                BasketItems = new List<BasketItemViewModel>(),
            };

            foreach (var item in cookieBasketItems)
            {
                Product product = _context.Products.Include(x => x.ProductImages).FirstOrDefault(x => x.Id == item.ProductId);
                BasketItemViewModel basketItem = new BasketItemViewModel
                {
                    Name = product.Name,
                    Price = product.DiscountPercent > 0 ? (product.SalePrice * (1 - product.DiscountPercent / 100)) : product.SalePrice,
                    ProductId = product.Id,
                    Count = item.Count,
                    PosterImage = product.ProductImages.FirstOrDefault(x => x.PosterStatus == true)?.Image
                };

                basketItem.TotalPrice = basketItem.Count * basketItem.Price;
                basket.TotalAmount += basketItem.TotalPrice;
                basket.BasketItems.Add(basketItem);
            }

            return basket;
        }

        private BasketViewModel _getBasketItems(List<BasketItem> basketItems)
        {
            BasketViewModel basket = new BasketViewModel
            {
                BasketItems = new List<BasketItemViewModel>(),
            };

            foreach (var item in basketItems)
            {
                BasketItemViewModel basketItem = new BasketItemViewModel
                {
                    Name = item.Product.Name,
                    Price = item.Product.DiscountPercent > 0 ? (item.Product.SalePrice * (1 - item.Product.DiscountPercent / 100)) : item.Product.SalePrice,
                    ProductId = item.Product.Id,
                    Count = item.Count,
                    PosterImage = item.Product.ProductImages.FirstOrDefault(x => x.PosterStatus == true)?.Image
                };

                basketItem.TotalPrice = basketItem.Count * basketItem.Price;
                basket.TotalAmount += basketItem.TotalPrice;
                basket.BasketItems.Add(basketItem);
            }

            return basket;
        }

        public async Task<IActionResult> DeleteBasket(int id)
        {
            if (!_context.Products.Any(x => x.Id == id))
            {
                return RedirectToAction("index", "error");
            }
            List<BasketItemViewModel> productsDetail = new List<BasketItemViewModel>();

            if (User.Identity.IsAuthenticated)
            {
                BasketItem basketItem = _context.BasketItems.FirstOrDefault(x => x.ProductId == id);
                if (basketItem == null)
                {
                    return RedirectToAction("index", "error");
                }
                if (basketItem.Count == 1)
                {
                    _context.BasketItems.Remove(basketItem);
                }
                else
                {
                    basketItem.Count--;
                }
                _context.SaveChanges();
            }
            else
            {
                string basket = HttpContext.Request.Cookies["basketItemList"];
                productsDetail = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basket);
                BasketItemViewModel productBasket = productsDetail.FirstOrDefault(x => x.ProductId == id);
                if (productBasket == null)
                {
                    return RedirectToAction("index", "error");
                }
                if (productBasket.Count == 1)
                {
                    productsDetail.Remove(productBasket);
                }
                else
                {
                    productBasket.Count--;
                }
                HttpContext.Response.Cookies.Append("basketItemList", JsonConvert.SerializeObject(productsDetail));
            }
            return View();

        }
    }
}
