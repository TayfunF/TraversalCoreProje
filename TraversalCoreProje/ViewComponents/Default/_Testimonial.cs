using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalCoreProje.BusinessLayer;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.ViewComponents
{
    public class _Testimonial : ViewComponent
    {
        TestimonialService _testimonialService = new TestimonialService(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            return View(_testimonialService.TGetList());
        }
    }
}
