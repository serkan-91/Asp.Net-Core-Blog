using CoreDemo.DataAccessLayer.UOW;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var values = _unitOfWork.Blogs.GetBlogListWithCategory();
            return View(values);
        }
    }
}
