using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.ViewComponents
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using AppDbContext _context = new AppDbContext();
            ViewBag.DestinationCount = _context.Destinations.Count();
            ViewBag.GuideCount = _context.Guides.Count();

            return View();
        }
    }
}
