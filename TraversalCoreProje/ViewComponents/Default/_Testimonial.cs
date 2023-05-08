using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalCoreProje.BusinessLayer.Concretes;
using TraversalCoreProje.DataAccessLayer.Repositories;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialService _testimonialService = new TestimonialService(new TestimonialRepository());
        public IViewComponentResult Invoke()
        {
            return View(_testimonialService.TGetList());
        }
    }
}
