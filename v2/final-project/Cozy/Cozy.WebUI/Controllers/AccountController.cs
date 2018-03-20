using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cozy.Domain.Models;
using Cozy.WebUI.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
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

        // Website URL calls this action
        [HttpGet]
        public IActionResult Register() => View();


        // Post from a form submit
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if(ModelState.IsValid) // form was completed correctly
            {
                var newUser = new ApplicationUser
                {
                    Email = viewModel.Email,
                    UserName = viewModel.Email
                };

               var result = await _userManager.CreateAsync(newUser, viewModel.Password);
               
                if(result.Succeeded) // user was created
                {
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("Index", "Home");
                }
                else // user was not created
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
               var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password incorrect");
                }
            }

            return View(viewModel);
        }
    }
}