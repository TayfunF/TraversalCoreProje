using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationService _destinationService = new DestinationService(new EfDestinationDal());
        public IActionResult Index()
        {
            return View(_destinationService.TGetList());
        }
    }
}
