using Devita.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles ="SuperAdmin,Admin")]

    public class SettingController : Controller
    {
        private readonly DevitaContext _context;

        public SettingController(DevitaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Settings.ToList());
        }

        public IActionResult Edit(int id)
        {
            Setting setting = _context.Settings.FirstOrDefault(x => x.Id==id);

            if(setting==null)
            {
                return RedirectToAction("index", "error");
            }

            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Setting setting)
        {
            Setting existSetting = _context.Settings.FirstOrDefault(x => x.Id == setting.Id);

            if(existSetting==null)
            {
                return RedirectToAction("index", "error");
            }

            if(!ModelState.IsValid)
            {
                return View();
            }

            existSetting.Value = setting.Value;

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
