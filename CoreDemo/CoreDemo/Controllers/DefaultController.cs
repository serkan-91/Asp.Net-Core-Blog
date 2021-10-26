using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult HeaderPartial ()
        {
            return PartialView();
        }
    }
}
