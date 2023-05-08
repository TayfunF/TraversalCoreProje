using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.ViewComponents
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationService destinationService = new DestinationService(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            return View(destinationService.TGetList());
        }
    }
}
