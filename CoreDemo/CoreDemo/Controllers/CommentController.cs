using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult _PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult _CommentListByBlog()
        {
            return PartialView();
        }
    }
}
