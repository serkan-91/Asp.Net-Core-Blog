using CoreDemo.BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public WriterLastBlog(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            var values = _unitOfWork.Blogs.GetAll(x => x.WriterId == 1);
            var take3fromlist = (from i in values select i).Take(3).ToList();
            return View(take3fromlist);
        }
    }
}
