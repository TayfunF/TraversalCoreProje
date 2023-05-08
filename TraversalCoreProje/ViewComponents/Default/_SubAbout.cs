using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer.Concretes;
using TraversalCoreProje.DataAccessLayer.Repositories;
namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutService _subAboutService = new SubAboutService(new SubAboutRepository());
        public IViewComponentResult Invoke()
        {
            return View(_subAboutService.TGetList());
        }
    }
}
