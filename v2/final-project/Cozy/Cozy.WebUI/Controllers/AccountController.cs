using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cozy.Domain.Models;
using Cozy.WebUI.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cozy.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly List<IdentityRole> _roles;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

            _roles = _roleManager.Roles.ToList();
        }

        // Website URL calls this action
        [HttpGet]
        public IActionResult Register()
        {
            var viewModel = new RegisterViewModel
            {
                Roles = new SelectList(_roles)
            };

            return View(viewModel);
        }


        // Post from a form submit
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid) // form was completed correctly
            {
                var newUser = new ApplicationUser
                {
                    Email = viewModel.Email,
                    UserName = viewModel.Email
                };

                var result = await _userManager.CreateAsync(newUser, viewModel.Password);

                if (result.Succeeded) // user was created
                {

                    // add the role to the user
                    // based on selection on dropdowm

                    result = await _userManager.AddToRoleAsync(newUser, viewModel.Role);

                    if (result.Succeeded) // the role was added to the user
                    {
                        await _signInManager.SignInAsync(newUser, false);

                        if(viewModel.Role == "Tenant")
                        {
                            return RedirectToAction("Index", "Tenant");
                        }
                        if(viewModel.Role == "Landlord")
                        {
                            return RedirectToAction("Index", "Landlord");
                        }
                    }
                }
                else // user was not created
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }

            viewModel.Roles = new SelectList(_roles);
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);

                if (result.Succeeded) // The credentials were correct
                {
                    var user = await _userManager.FindByEmailAsync(viewModel.Email);
                    var isLandlord = await _userManager.IsInRoleAsync(user, "Landlord");
                    var isTenant = await _userManager.IsInRoleAsync(user, "Tenant");

                    if (isLandlord)
                    {
                        return RedirectToAction("Index", "Landlord");
                    }
                    if (isTenant)
                    {
                        return RedirectToAction("Index", "Tenant");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password incorrect");
                }
            }

            return View(viewModel);
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}