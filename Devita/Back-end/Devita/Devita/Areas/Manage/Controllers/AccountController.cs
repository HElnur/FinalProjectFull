using Devita.Areas.Manage.ViewModels;
using Devita.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly DevitaContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(DevitaContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult SignIn()
        {
            //AppUser user = _userManager.FindByNameAsync("SuperAdmin").Result;
            //var result = _userManager.AddToRoleAsync(user, "SuperAdmin").Result;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(AdminSignInViewModel adminVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool adminOrMember = await _userManager.Users.AnyAsync(x => x.IsAdmin);
            if (adminOrMember == true)
            {
                AppUser admin = await _userManager.FindByNameAsync(adminVM.UserName);

                if (admin == null)
                {
                    ModelState.AddModelError("", "Username or password is incorrect!");
                    return View();
                }

                var result = await _signInManager.PasswordSignInAsync(admin, adminVM.Password, false, false);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Username or password is incorret!");
                    return View();
                }

            }

            return RedirectToAction("index", "dashboard");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("signin", "account");
        }

        public async Task<IActionResult> CreateAdmin()
        {
            AppUser appUser = new AppUser
            {
                UserName = "SuperAdmin",
                FullName = "Super Admin"
            };

            var result = await _userManager.CreateAsync(appUser, "Admin12345");

            return Ok(result);
        }


    }
}
