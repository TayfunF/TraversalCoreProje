using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer.Abstracts;
using TraversalCoreProje.BusinessLayer.Concretes;
using TraversalCoreProje.DataAccessLayer.Repositories;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureService _featureService = new FeatureService(new FeatureRepository());
        public IViewComponentResult Invoke()
        {
            return View(_featureService.TGetList());
        }
    }
}
