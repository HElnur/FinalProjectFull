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
    public class WrapperController : Controller
    {
        private readonly DevitaContext _context;
        private readonly IWebHostEnvironment _env;

        public WrapperController(DevitaContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.Wrappers.ToList());
        }

        public IActionResult Edit(int id)
        {
            Wrapper wrapper = _context.Wrappers.FirstOrDefault(x => x.Id == id);

            if (wrapper == null)
            {
                return RedirectToAction("index", "error");
            }

            return View(wrapper);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Wrapper wrapper)
        {

            Wrapper existWrapper = _context.Wrappers.FirstOrDefault(x => x.Id == wrapper.Id);

            if (existWrapper == null)
            {
                return RedirectToAction("index", "error");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (wrapper.ImageFile1 != null)
            {
                if (wrapper.ImageFile1.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile1", "Image 1 max size is 2MB!");
                    return View();
                }

                else if (wrapper.ImageFile1.ContentType != "image/jpeg" && wrapper.ImageFile1.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile1", "ContentType must be image/jpeg or image/png!");
                    return View();
                }

                FileManager.Delete(_env.WebRootPath, "uploads/wrapper", existWrapper.Image1);
                existWrapper.Image1 = FileManager.Save(_env.WebRootPath, "uploads/wrapper", wrapper.ImageFile1);
            }

            if (wrapper.ImageFile2 != null)
            {
                if (wrapper.ImageFile2.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile2", "Image 2 max size is 2MB!");
                    return View();
                }

                else if (wrapper.ImageFile2.ContentType != "image/jpeg" && wrapper.ImageFile1.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile2", "ContentType must be image/jpeg or image/png!");
                    return View();
                }

                FileManager.Delete(_env.WebRootPath, "uploads/wrapper", existWrapper.Image2);
                existWrapper.Image2 = FileManager.Save(_env.WebRootPath, "uploads/wrapper", wrapper.ImageFile2);
            }

            _context.SaveChanges();

            return RedirectToAction("index");
        }

    }
}
