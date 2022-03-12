using Devita.Helper;
using Devita.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Areas.Manage.Controllers
{
    [Area("manage")]
    public class HomeStaticController : Controller
    {
        private readonly DevitaContext _context;
        private readonly IWebHostEnvironment _env;

        public HomeStaticController(DevitaContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.HomeStatics.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HomeStatic hStatic)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (hStatic.BgImageFile == null)
            {
                ModelState.AddModelError("BgImageFile", "Background image is required!");
            }

            else if (hStatic.BgImageFile.Length > 2097152)
            {
                ModelState.AddModelError("BgImageFile", "Background image max size is 2MB!");
                return View();
            }

            else if (hStatic.BgImageFile.ContentType != "image/jpeg" && hStatic.BgImageFile.ContentType != "image/png")
            {
                ModelState.AddModelError("BgImageFile", "ContentType must be image/jpeg or image/png!");
                return View();
            }

            hStatic.BgImage = FileManager.Save(_env.WebRootPath, "uploads/homestatic", hStatic.BgImageFile);

            _context.HomeStatics.Add(hStatic);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            HomeStatic hStatic = _context.HomeStatics.FirstOrDefault(x => x.Id == id);
            if(hStatic==null)
            {
                return RedirectToAction("index", "error");
            }

            return View(hStatic);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HomeStatic hStatic)
        {
            HomeStatic existStatic = _context.HomeStatics.FirstOrDefault(x => x.Id == hStatic.Id);

            if(existStatic==null)
            {
                return RedirectToAction("index", "error");
            }

            if(!ModelState.IsValid)
            {
                return View();
            }

            if(hStatic.BgImageFile != null)
            {
                if (hStatic.BgImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("BgImageFile", "Background image max size is 2MB!");
                    return View();
                }

                else if (hStatic.BgImageFile.ContentType != "image/jpeg" && hStatic.BgImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("BgImageFile", "ContentType must be image/jpeg or image/png!");
                    return View();
                }

                FileManager.Delete(_env.WebRootPath, "uploads/homestatic", existStatic.BgImage);
                existStatic.BgImage = FileManager.Save(_env.WebRootPath, "uploads/homestatic", hStatic.BgImageFile);
            }

            existStatic.Title = hStatic.Title;
            existStatic.Desc = hStatic.Desc;
            existStatic.ButtonText = hStatic.ButtonText;
            existStatic.ButtonUrl = hStatic.ButtonUrl;
            existStatic.Price = hStatic.Price;

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
