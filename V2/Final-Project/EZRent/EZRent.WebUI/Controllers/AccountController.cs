using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZRent.Domain.Models;
using EZRent.WebUI.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EZRent.WebUI.Controllers
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

        //when someone hits account/register
        [HttpGet]
        public IActionResult Register()
        {
            var viewModel = new RegisterViewModel
            {
                Roles = new SelectList(_roles)
            };


            return View(viewModel);
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

                    result = await _userManager.AddToRoleAsync(newUser, viewModel.Role);

                    if (result.Succeeded)
                    {
                    // auto log in the new user
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

                } else // try to create user, but it failed 
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }

            }
            viewModel.Roles = new SelectList(_roles);
            return View(viewModel);
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

                if (result.Succeeded) // Credentials are correct
                {
                    var user = await _userManager.FindByEmailAsync(viewModel.Email);
                    var isLandlord = await _userManager.IsInRoleAsync(user, "Landlord");
                    var isTenant = await _userManager.IsInRoleAsync(user, "Tenant");

                    if (isLandlord)
                    {
                        return RedirectToAction("Index", "Landlord");
                    }
                    if(isTenant)
                    {
                    return RedirectToAction("Index", "Tenant");

                    }
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password Invalid");
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