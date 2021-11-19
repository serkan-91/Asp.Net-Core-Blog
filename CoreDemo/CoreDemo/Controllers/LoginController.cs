using CoreDemo.BusinessLayer.Service;
using CoreDemo.Shared.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p,string returnUrl = null)
        {
             var IsExist = _unitOfWork.Writers.GetByFilter(x=>x.WriterMail == p.WriterMail && 
             x.WriterPassword == p.WriterPassword);

            if (IsExist != null && IsExist.WriterStatus != false)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, IsExist.WriterMail)
                };
                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                if (returnUrl !=null)
                {
                    return Redirect(returnUrl);

                }
                else
                {
                    return RedirectToAction("Index", "Writer");
                }
            }
            else
            {
                var currentUrl = HttpContext.Request.Headers["Referer"];

                return Redirect(currentUrl);
            }
        }

        
    }
}
