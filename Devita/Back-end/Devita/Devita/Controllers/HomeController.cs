using Devita.Models;
using Devita.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Controllers
{
    public class HomeController : Controller
    {
        private readonly DevitaContext _context;

        public HomeController(DevitaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                NewProducts = _context.Products.Include(x => x.ProductImages).Where(x => x.IsNew).ToList(),
                FeaturedProducts = _context.Products.Include(x => x.ProductImages).Where(x => x.IsFeatured).ToList(),
                BestProducts = _context.Products.Include(x => x.ProductImages).Where(x => x.IsBest).ToList(),
                TopHeadphonesProduct = _context.Products.Include(x => x.ProductImages).Where(x => x.IsTopHeadphone).ToList(),
                TopRates = _context.Products.Include(x => x.ProductImages).Where(x => x.IsTopRate).ToList(),
                Sliders = _context.Sliders.ToList(),
                Wrappers = _context.Wrappers.ToList(),
                HomeStatics = _context.HomeStatics.ToList()
            };
            return View(homeVM);
        }

        
    }
}
