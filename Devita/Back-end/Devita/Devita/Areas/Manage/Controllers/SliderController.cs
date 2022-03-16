using Devita.Helper;
using Devita.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Areas.Manage.Controllers
{
    [Area("manage")]
    //[Authorize(Roles = "SuperAdmin,Admin")]
    public class SliderController : Controller
    {
        private readonly DevitaContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(DevitaContext context , IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {

            return View(_context.Sliders.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            if (slider.BgImageFile == null)
            {
                ModelState.AddModelError("BgImageFile", "Background image is required!");
            }

            else if(slider.BgImageFile.Length > 2097152)
            {
                ModelState.AddModelError("BgImageFile", "Background image max size is 2MB!");
            }

            else if(slider.BgImageFile.ContentType != "image/jpeg" && slider.BgImageFile.ContentType != "image/png")
            {
                ModelState.AddModelError("BgImageFile", "ContentType must be image/jpeg or image/png!");
            }

            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2MB!");
                }

                else if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "ContentType must be image/jpeg or image/png!");
                }

                if (!ModelState.IsValid)
                {
                    return View();
                }

                slider.Image = FileManager.Save(_env.WebRootPath, "uploads/slider", slider.ImageFile);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            slider.BgImage = FileManager.Save(_env.WebRootPath, "uploads/slider", slider.BgImageFile);

            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if(slider==null)
            {
                return RedirectToAction("index", "error");
            }
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Slider slider)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null)
            {
                return RedirectToAction("index", "error");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (slider.ImageFile != null)
            {

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2MB!");
                    return View();
                }

                else if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "ContentType must be image/jpeg or image/png!");
                    return View();
                }
                
                if(slider.Image != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/slider", existSlider.Image);
                    existSlider.Image = FileManager.Save(_env.WebRootPath, "uploads/slider", slider.ImageFile);
                }
            }

            else if (slider.Image == null)
            {

                if(slider.ImageFile == null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/slider", existSlider.Image);

                    existSlider.Image = null;
                }

             
                

            }

            existSlider.Text = slider.Text;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult GetImage(int id)
        {
            ProductImage prodImage = _context.ProductImages.FirstOrDefault(x => x.Id == id);
            return Ok(prodImage);
        }

        public IActionResult Delete(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
            {
                return RedirectToAction("index", "error");
            }

            return View(slider);
        }

        [HttpPost]
        public IActionResult Delete(Slider slider)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null)
            {
                return RedirectToAction("index", "error");
            }

            FileManager.Delete(_env.WebRootPath, "uploads/slider", existSlider.BgImage);
            FileManager.Delete(_env.WebRootPath, "uploads/slider", existSlider.Image);

            _context.Sliders.Remove(existSlider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }




    }
}
