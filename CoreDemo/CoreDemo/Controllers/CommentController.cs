using Microsoft.AspNetCore.Mvc;
using CoreDemo.BusinessLayer.Service;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult _PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult _CommentListByBlog(int id)
        {
            var values = _unitOfWork.Comments.GetAll(x => x.BlogId == id);
            return PartialView(values);
        }
    }
}
