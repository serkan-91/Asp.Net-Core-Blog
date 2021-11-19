using CoreDemo.BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogLast3Post:ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogLast3Post(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.Blogs.GetLast3Blog();
            return View(values);
        }
    }
}
