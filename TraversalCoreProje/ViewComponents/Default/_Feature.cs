using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.ViewComponents
{
    public class _Feature : ViewComponent
    {
        FeatureService _featureService = new FeatureService(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            return View(_featureService.TGetList());
        }
    }
}
