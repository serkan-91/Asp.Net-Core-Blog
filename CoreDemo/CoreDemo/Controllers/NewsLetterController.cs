using CoreDemo.BusinessLayer.Service;
using CoreDemo.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
      private readonly  IUnitOfWork _unitOfWork;

        public NewsLetterController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public PartialViewResult _SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult _SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            _unitOfWork.NewsLetters.Add(p); 
            return PartialView();
        }
    }
}
