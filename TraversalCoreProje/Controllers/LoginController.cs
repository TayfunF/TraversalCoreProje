using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.EntityLayer;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterVM userRegisterVM)
        {
            AppUser appUser = new AppUser()
            {
                Name = userRegisterVM.Name,
                Surname = userRegisterVM.Surname,
                Email = userRegisterVM.Email,
                UserName = userRegisterVM.Username
            };

            if (userRegisterVM.Password == userRegisterVM.ConfirmPassword)
            {
                IdentityResult result = await _userManager.CreateAsync(appUser, userRegisterVM.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Profile", new { area = "Member" });
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInVM userSignInVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userSignInVM.Username, userSignInVM.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Destination");
                }
                else
                {
                    return RedirectToAction("SigIn", "Login");
                }
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı ya da şifre hatalı");
            }
            return View();
        }
    }
}
