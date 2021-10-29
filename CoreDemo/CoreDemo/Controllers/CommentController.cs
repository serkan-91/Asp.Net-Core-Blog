using Microsoft.AspNetCore.Mvc;
using CoreDemo.BusinessLayer.Service;
using CoreDemo.Shared.Models;
using System;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult _PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            _unitOfWork.Comments.Add(p);
            return PartialView();
        }
        public PartialViewResult _CommentListByBlog(int id)
        {
            var values = _unitOfWork.Comments.GetAll(x => x.BlogId == id);
            return PartialView(values);
        }
    }
}
