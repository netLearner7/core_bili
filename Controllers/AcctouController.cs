using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using core_bili.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace core_bili.Controllers
{
    public class AcctouController : Controller
    {
        
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public AcctouController(SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> userManager) {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login() {

            return  View();
        }

        //只有登陆的用户才能使用这个功能
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Login(User loginViewModel)
        {
            if (!ModelState.IsValid) {
                return View(loginViewModel);
            }
            
            var user = await userManager.FindByNameAsync(loginViewModel.Name);
            if (user != null) {
                var result = await signInManager.PasswordSignInAsync(user, loginViewModel.PassWord, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
            }

            ModelState.AddModelError("","账户密码不正确!");

            return View(loginViewModel);
        }


        public IActionResult Register() {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User viewModel) {

            if (ModelState.IsValid) {
                var user = new IdentityUser {
                    UserName = viewModel.Name,
                };
            
                var Result=await userManager.CreateAsync(user, viewModel.PassWord);

          

                if (Result.Succeeded) {
                    return RedirectToAction("Index", "Home");
                }
            }
                                 
            return View(viewModel);
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }

    }
}