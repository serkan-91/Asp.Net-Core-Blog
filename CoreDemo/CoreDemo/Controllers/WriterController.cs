using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult _WriterNavbarPartial()
        {
            return PartialView();

        }
        public PartialViewResult _WriterFooterPartial()
        {
            return PartialView();
        }
    }
}
