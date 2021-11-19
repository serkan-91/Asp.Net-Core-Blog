using CoreDemo.BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        private  readonly IUnitOfWork _unitOfWork;

        public BlogListDashboard(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.Blogs.GetBlogListWithCategory();
            return View(values);
        }
    }
}
