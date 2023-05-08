using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
