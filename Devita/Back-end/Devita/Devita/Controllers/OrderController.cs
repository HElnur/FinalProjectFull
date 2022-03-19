using Devita.Models;
using Devita.ViewModels;
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
    public class OrderController : Controller
    {
        private readonly DevitaContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(DevitaContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Checkout()
        {
            CheckOutViewModel checkoutVM = new CheckOutViewModel
            {
                CheckoutItems = await _getCheckoutItems(),
                Order = new Order()
            };
            return View(checkoutVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Order order)
        {
            

            AppUser user = _userManager.Users.FirstOrDefault(x => x.IsAdmin == false && x.UserName == User.Identity.Name);
            if (user == null)
            {
                return RedirectToAction("index", "error");
            }

            
            List<CheckOutItemViewModel> checkoutItems = await _getCheckoutItems();

            if (checkoutItems.Count == 0)
            {
                ModelState.AddModelError("", "There is not any selected product");
            }

            if (!ModelState.IsValid)
            {
                return View("Checkout", new CheckOutViewModel { CheckoutItems = checkoutItems, Order = order });
            }

            var lastOrder = _context.Order.OrderByDescending(x => x.Id).FirstOrDefault();
            order.CreatedAt = DateTime.UtcNow.AddHours(4);
            order.Status = Enum.OrderStatus.Pending;
            order.DeliveryStatus = Enum.OrderDeliveryStatus.OnProcessing;
            order.OrderItems = new List<OrderItem>();
            //order.AppUserId = user.Id;
            foreach (var item in checkoutItems)
            {
                OrderItem orderItem = new OrderItem
                {
                    
                    ProductId = item.Product.Id,
                    CostPrice = item.Product.CostPrice,
                    Count = item.Count,
                    SalePrice = item.Product.SalePrice,
                    DiscountPercent = item.Product.DiscountPercent
                };
                order.TotalAmount += orderItem.DiscountPercent > 0
                ? orderItem.SalePrice * (1 - orderItem.DiscountPercent / 100) * orderItem.Count
                : orderItem.SalePrice * orderItem.Count;
                order.OrderItems.Add(orderItem);
            }
           
            _context.Order.Add(order);
            _context.BasketItems.RemoveRange(_context.BasketItems.Where(x => x.AppUserId == user.Id));
            _context.SaveChanges();
            return RedirectToAction("profile", "account");
        }



        private async Task<List<CheckOutItemViewModel>> _getCheckoutItems()
        {
            List<CheckOutItemViewModel> checkoutItems = new List<CheckOutItemViewModel>();

            AppUser user = null;
            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);
            }

            if (user != null && user.IsAdmin == false)
            {
                List<BasketItem> basketItems = _context.BasketItems.Include(x => x.Product).ThenInclude(x => x.ProductImages).Where(x => x.AppUserId == user.Id).ToList();

                foreach (var item in basketItems)
                {
                    CheckOutItemViewModel checkoutItem = new CheckOutItemViewModel
                    {
                        Product = item.Product,
                        Count = item.Count
                    };
                    checkoutItems.Add(checkoutItem);
                }
            }
            else
            {
                string basketItemsStr = HttpContext.Request.Cookies["basketItemList"];
                if (basketItemsStr != null)
                {
                    List<CookieBasketItemViewModel> basketItems = JsonConvert.DeserializeObject<List<CookieBasketItemViewModel>>(basketItemsStr);

                    foreach (var item in basketItems)
                    {
                        CheckOutItemViewModel checkoutItem = new CheckOutItemViewModel
                        {
                            Product = _context.Products.Include(x => x.ProductImages).FirstOrDefault(x => x.Id == item.ProductId),
                            Count = item.Count
                        };
                        checkoutItems.Add(checkoutItem);
                    }
                }
            }

            return checkoutItems;
        }
    }
}
