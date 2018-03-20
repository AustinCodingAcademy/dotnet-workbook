using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZRent.Domain.Models;
using EZRent.WebUI.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EZRent.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //when someone hits account/register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //submit a form
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            //check if information is correct
            if (ModelState.IsValid)
            {
                var newUser = new ApplicationUser
                {
                    Email = viewModel.Email,
                    UserName = viewModel.Email
                };

                var result = await _userManager.CreateAsync(newUser, viewModel.Password);

                if (result.Succeeded) //if user was created
                {
                    // auto log in the new user
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("Index", "Home");
                } else // try to create user, but it failed 
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }

            }
            return RedirectToAction("Register", viewModel);
        }

        //URL : Account/Login
        [HttpGet]
        public IActionResult Login() => View();

        // submit the form
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password Invalid");
                }
            }
            return RedirectToAction("Login");
        }
    }
}