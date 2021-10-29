using CoreDemo.BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class AboutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AboutController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var values = _unitOfWork.Abouts.GetAll();

            return View(values);
        }
        public PartialViewResult _SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
