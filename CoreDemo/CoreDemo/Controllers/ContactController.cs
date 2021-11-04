using CoreDemo.BusinessLayer.Service;
using CoreDemo.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            _unitOfWork.Contacts.Add(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
