using CoreDemo.BusinessLayer.Concrete;
using CoreDemo.DataAccessLayer.EntityFramework;
using CoreDemo.DataAccessLayer.UOW;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var values = _unitOfWork.Categories.GetAll();
            return View(values);
        }
    }
}
