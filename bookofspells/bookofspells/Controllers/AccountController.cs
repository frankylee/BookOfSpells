using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookofspells.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bookofspells.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userMngr, SignInManager<AppUser> signInMngr)
        {
            userManager = userMngr;
            signInManager = signInMngr;
        }


        [Authorize]
        public async Task<IActionResult> IndexAsync()
        {
            AppUser user = await userManager.GetUserAsync(User);
            ViewBag.User = user;
            return View();
        }


        // GET: /<controller>/
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }


        //[HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult LogIn()//string returnAfterLoginUrl = "")
        {
            //var model = new LoginVM { ReturnUrl = returnAfterLoginUrl };
            //return View(model);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginVM model)//, string returnAfterLoginUrl = "")
        {
            if (ModelState.IsValid)
            {
                //model.ReturnUrl = returnAfterLoginUrl;

                var result = await signInManager.PasswordSignInAsync(
                    model.UserName,
                    model.Password,
                    isPersistent: model.RememberMe,
                    lockoutOnFailure: false
                );

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }


        public ViewResult AccessDenied()
        {
            return View();
        }
    }
}
