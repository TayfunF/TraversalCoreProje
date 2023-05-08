using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer.Concretes;
using TraversalCoreProje.DataAccessLayer.Repositories;
using TraversalCoreProje.EntityLayer.Concrete;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationService _destinationService = new DestinationService(new DestinationRepository());
        public IActionResult Index()
        {
            return View(_destinationService.TGetList());
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            return View(_destinationService.TGetById(id));
        }

        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
