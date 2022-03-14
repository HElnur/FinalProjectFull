using Devita.Models;
using Devita.Services;
using Devita.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Controllers
{
    public class AccountController : Controller
    {
        private readonly DevitaContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;

        public AccountController(DevitaContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager , RoleManager<IdentityRole> roleManager , IEmailService emailService)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailService = emailService;
        }

        public IActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index","home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(MemberSignInViewModel memberVM)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            

            AppUser member = await _userManager.Users.FirstOrDefaultAsync(x => !x.IsAdmin && x.NormalizedUserName == memberVM.UserName.ToUpper());

            if (member==null)
            {
                ModelState.AddModelError("", "Username or password is incorrect!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(member , memberVM.Password, false , false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is incorrect!");
                return View();
            }


            return RedirectToAction("index", "home");
        }

        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(MemberRegisterViewModel memberVM)
        {

            var userExistEmail = await _userManager.FindByEmailAsync(memberVM.Email);
            if (userExistEmail != null)
            {
                ModelState.AddModelError("Email", "Email is Already!");
            }
            var userExistUsername = await _userManager.FindByNameAsync(memberVM.UserName);
            if (userExistUsername != null)
            {
                ModelState.AddModelError("Username", "Username is Already!");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }


            AppUser newUser = new AppUser
            {
                UserName = memberVM.UserName,
                Email = memberVM.Email,
                IsAdmin = false,
                FullName = memberVM.FullName
            };

            var result = await _userManager.CreateAsync(newUser, memberVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newUser, "Member");
            await _signInManager.PasswordSignInAsync(newUser, memberVM.Password, false, false);

            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> Forgot()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Forgot(ForgotPasswordViewModel forgotVM)
        {
            AppUser user = await _userManager.FindByEmailAsync(forgotVM.Email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "User not found!");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("resetpassword", "account", new { email = forgotVM.Email, token = token }, Request.Scheme);

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/templateHtml/reset-password-email.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{{url}}", url);
            

            _emailService.Send(forgotVM.Email, "ChangePassword", body);
            return RedirectToAction("SignIn", "account");
        }

        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetVM)
        {
            if (resetVM.Email==null)
            {
                return RedirectToAction("index", "error");
            }
            AppUser user = await _userManager.FindByEmailAsync(resetVM.Email);
            if (user == null || !(await _userManager.VerifyUserTokenAsync(user, _userManager.Options.Tokens.PasswordResetTokenProvider, "ResetPassword", resetVM.Token)))
            {
                return RedirectToAction("SignIn", "account");
            }
            return View(resetVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ResetPasswordViewModel resetVM)
        {
            if (string.IsNullOrWhiteSpace(resetVM.Password) || resetVM.Password.Length > 25)
                ModelState.AddModelError("Password", "Password is required and must be less than 25 character");
            if (!ModelState.IsValid)
            {
                return View("ResetPassword", resetVM);
            }
            AppUser user = await _userManager.FindByEmailAsync(resetVM.Email);
            if (user == null)
            {
                return RedirectToAction("login", "account");
            }
            var result = await _userManager.ResetPasswordAsync(user, resetVM.Token, resetVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ResetPassword", resetVM);
            }
            return RedirectToAction("SignIn", "account");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn", "account");
        }


        [Authorize(Roles="Member")]
        public async Task<IActionResult> Profile()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileViewModel profileVM = new ProfileViewModel
            {
                Member = new MemberUpdateViewModel
                {
                    Email = user.Email,
                    FullName = user.FullName,
                    UserName = user.UserName
                },
                Orders = _context.Order.Include(x => x.OrderItems).ThenInclude(x => x.Product).Where(x => x.AppUserId == user.Id).ToList()
            };
            return View(profileVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Member")]
        public async Task<IActionResult> Profile(MemberUpdateViewModel memberVM)
        {
            AppUser member = await _userManager.FindByNameAsync(User.Identity.Name);

            ProfileViewModel profileVM = new ProfileViewModel
            {
                Member = memberVM,
            };

            if (member.Email != memberVM.Email && _userManager.Users.Any(x => x.NormalizedEmail == memberVM.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "Email is already!");
                return View();
            }

            

            //if (!ModelState.IsValid)
            //{
            //    return View(profileVM);
            //}

            

            member.Email = memberVM.Email;
            //member.UserName = memberVM.UserName;
            member.FullName = memberVM.FullName;

            var result = await _userManager.UpdateAsync(member);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            if (!string.IsNullOrWhiteSpace(memberVM.Password) || !string.IsNullOrWhiteSpace(memberVM.RepeatPassword))
            {
                if (memberVM.Password!= memberVM.RepeatPassword)
                {
                    return View(profileVM);
                }

                if (!await _userManager.CheckPasswordAsync(member , memberVM.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Current password is incorrect!");
                    return View();
                }

                var passwordResult = await _userManager.ChangePasswordAsync(member, memberVM.CurrentPassword, memberVM.Password);

                if (!passwordResult.Succeeded)
                {
                    foreach (var item in passwordResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View(profileVM);
                }
            }
            _context.SaveChanges();
            await _signInManager.SignInAsync(member, true);

            return View(profileVM);
        }

        


        //public async Task<IActionResult> CreateRole()
        //{
        //    var role1 = await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        //    var role2 = await _roleManager.CreateAsync(new IdentityRole("Admin"));
        //    var role3 = await _roleManager.CreateAsync(new IdentityRole("Member"));

        //    AppUser SuperAdmin = new AppUser { FullName = "Super Admin", UserName = "SuperAdmin" };
        //    var admin = await _userManager.CreateAsync(SuperAdmin, "Admin123");
        //    var resultRole = await _userManager.AddToRoleAsync(SuperAdmin, "SuperAdmin");

        //    return Ok(resultRole);
        //}

    }


}
