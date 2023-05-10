using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Member.Models;
using TraversalCoreProje.EntityLayer;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditVM userEditVM = new UserEditVM();
            userEditVM.Name = values.Name;
            userEditVM.Surname = values.Surname;
            userEditVM.UserName = values.UserName;
            userEditVM.Email = values.Email;
            userEditVM.PhoneNumber = values.PhoneNumber;

            return View(userEditVM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditVM userEditVM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (userEditVM.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditVM.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userEditVM.Image.CopyToAsync(stream);
                user.ImageUrl = "/userimages/" + imageName;
            }

            user.Name = userEditVM.Name;
            user.Surname = userEditVM.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditVM.Password);
            user.PhoneNumber = userEditVM.PhoneNumber;
            user.Email = userEditVM.Email;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }
}
