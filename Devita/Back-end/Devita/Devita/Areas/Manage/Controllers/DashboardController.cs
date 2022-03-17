using Devita.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
        private readonly DevitaContext _context;

        public DashboardController(DevitaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var order = _context.Order.Where(x => x.Status == Enum.OrderStatus.Accepted).ToList();
            var orderMonth = _context.Order.Where(x => x.Status == Enum.OrderStatus.Accepted).Where(x => x.CreatedAt.Month == DateTime.Now.Month).ToList();
            var user = _context.Users.Where(x => x.IsAdmin == false).ToList();
            var month = DateTime.Now.ToString("MMMM");
            var products = _context.Products.ToList();
            ViewBag.UsersCount = user.Count();
            ViewBag.ProductCount = products.Count();
            ViewBag.Month = month;
            decimal totalOrderAmount = 0;
            decimal totalOrderMonthAmount = 0;
            foreach (var item in order)
            {
                totalOrderAmount += item.TotalAmount;
            }

            foreach (var item in orderMonth)
            {
                totalOrderMonthAmount += item.TotalAmount;
            }

            ViewBag.TotalOrder = totalOrderAmount;
            ViewBag.TotalOrderMonth = totalOrderMonthAmount;

            return View();
        }
    }
}
