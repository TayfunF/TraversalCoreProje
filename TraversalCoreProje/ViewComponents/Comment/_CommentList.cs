using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.BusinessLayer;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.ViewComponents
{
    public class _CommentList : ViewComponent
    {
        CommentService _commentService = new CommentService(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            return View(_commentService.TGetDestinationById(id));
        }
    }
}
