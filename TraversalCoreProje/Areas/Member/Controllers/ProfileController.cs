using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
            userEditVM.Email = values.Email;
            userEditVM.Phone = values.PhoneNumber;

            return View(userEditVM);
        }


    }
}
