using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.ViewComponents
{
    public class _SubAbout : ViewComponent
    {
        SubAboutService _subAboutService = new SubAboutService(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            return View(_subAboutService.TGetList());
        }
    }
}
