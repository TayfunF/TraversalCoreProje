using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer;
using TraversalCoreProje.DataAccessLayer;
using TraversalCoreProje.EntityLayer;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationService _destinationService = new DestinationService(new EfDestinationDal());
        public IActionResult Index()
        {
            return View(_destinationService.TGetList());
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.Id = id;
            return View(_destinationService.TGetById(id));
        }

        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
