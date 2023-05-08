using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer.Concretes;
using TraversalCoreProje.DataAccessLayer.Abstract;
using TraversalCoreProje.DataAccessLayer.Repositories;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationService destinationService = new DestinationService(new DestinationRepository());
        public IViewComponentResult Invoke()
        {
            return View(destinationService.TGetList());
        }
    }
}
