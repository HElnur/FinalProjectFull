using Devita.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class OrderController : Controller
    {
        private readonly DevitaContext _context;

        public OrderController(DevitaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var order = _context.Order.Include(x => x.OrderItems).ToList();

            if(order==null)
            {
                return RedirectToAction("index", "error");
            }

            return View(order);
        }

        public IActionResult AcceptOrder(int id)
        {
            var existOrder = _context.Order.FirstOrDefault(x => x.Id == id);

            if(existOrder==null)
            {
                return RedirectToAction("index", "error");
            }

            existOrder.Status = Enum.OrderStatus.Accepted;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        //[HttpPost]
        public IActionResult RejectOrder(int id)
        {

            var existOrder = _context.Order.FirstOrDefault(x => x.Id == id);

            if (existOrder == null)
            {
                return RedirectToAction("index", "error");
            }


            existOrder.Status = Enum.OrderStatus.Rejected;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult OrderContain(int id)
        {
            var order = _context.Order.Include(x => x.OrderItems).ThenInclude(x => x.Product).FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return RedirectToAction("index", "error");
            }
            return View(order);
        }

        public IActionResult StatusDeliver(int id)
        {
            var existOrder = _context.Order.FirstOrDefault(x => x.Id == id);
            if (existOrder == null)
            {
                return RedirectToAction("index", "error");
            }
            existOrder.DeliveryStatus = Enum.OrderDeliveryStatus.Delivered;
            _context.SaveChanges();
            return RedirectToAction("OrderContain", new { Id = existOrder.Id });
        }
        public IActionResult StatusProcess(int id)
        {
            var existOrder = _context.Order.FirstOrDefault(x => x.Id == id);
            if (existOrder == null)
            {
                return RedirectToAction("index", "error");
            }
            existOrder.DeliveryStatus = Enum.OrderDeliveryStatus.OnProcessing;
            _context.SaveChanges();
            return RedirectToAction("OrderContain", new { Id = existOrder.Id });
        }

        public IActionResult StatusCourier(int id)
        {
            var existOrder = _context.Order.FirstOrDefault(x => x.Id == id);
            if (existOrder == null)
            {
                return RedirectToAction("index", "error");
            }
            existOrder.DeliveryStatus = Enum.OrderDeliveryStatus.OnCourier;
            _context.SaveChanges();
            return RedirectToAction("OrderContain", new { Id = existOrder.Id });
        }
        public IActionResult StatusDepo(int id)
        {
            var existOrder = _context.Order.FirstOrDefault(x => x.Id == id);
            if (existOrder == null)
            {
                return RedirectToAction("index", "error");
            }
            existOrder.DeliveryStatus = Enum.OrderDeliveryStatus.OnDepo;
            _context.SaveChanges();
            return RedirectToAction("OrderContain", new { Id = existOrder.Id });
        }
    }
}
