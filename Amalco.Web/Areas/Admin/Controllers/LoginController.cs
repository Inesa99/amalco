using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Amalco.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var user = new IdentityUser {Email="amalco@amalco.ru",UserName="amalco@amalco.ru" };
            //var result = await _userManager.CreateAsync(user, "pPurofi87doer74!ch");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string mail,string password)
        {
            var result = await _signInManager.PasswordSignInAsync(mail, password, true, false);
            if(result.Succeeded)
            {
              return Redirect("/Admin/ServiceManage/Index");
            }
            else
            {
                return View();
            }
           
        }
    }
}