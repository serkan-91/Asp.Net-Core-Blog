using CoreDemo.BusinessLayer.Service;
using CoreDemo.BusinessLayer.ValidationRules;
using CoreDemo.Shared.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var values = _unitOfWork.Blogs.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            var values = _unitOfWork.Blogs.GetAll(x => x.BlogId == id);
            ViewData["BlogId"] = id;

            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var values = _unitOfWork.Blogs.GetBlogListWithCategoryByWriter(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValues = (from x in _unitOfWork.Categories.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bv = new();

            ValidationResult result = bv.Validate(p);

            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = 1;

                _unitOfWork.Blogs.Add(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();

        }

        public IActionResult DeleteBlog(int id)
        {

            var blogValue = _unitOfWork.Blogs.GetById(id);
            if (blogValue != null)
            {
                blogValue.BlogStatus = false;
                _unitOfWork.Blogs.Update(blogValue);
                return RedirectToAction("BlogListByWriter");

            }
            else
            {
                return RedirectToAction("BlogListByWriter");
            }
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {

            var blogvalue = _unitOfWork.Blogs.GetById(id);

            List<SelectListItem> categoryValues = (from x in _unitOfWork.Categories.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View(blogvalue);

        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            BlogValidator bv = new();

            ValidationResult result = bv.Validate(p);

            if (result.IsValid)
            {
                var currentBlog = _unitOfWork.Blogs.GetById(p.BlogId);

                currentBlog.BlogId = p.BlogId;
                currentBlog.BlogTitle = p.BlogTitle;
                currentBlog.BlogThumbnailImage = p.BlogThumbnailImage;
                currentBlog.BlogImage = p.BlogImage;
                currentBlog.BlogStatus = p.BlogStatus;
                currentBlog.WriterId = currentBlog.WriterId;
                currentBlog.BlogContent = p.BlogContent;
                currentBlog.CategoryId = p.CategoryId;
                currentBlog.BlogCreateDate = currentBlog.BlogCreateDate;



                _unitOfWork.Blogs.Update(currentBlog);
                return RedirectToAction("BlogListByWriter");
            }
            else
            {
                var currentPage = HttpContext.Request.Headers["Referer"];
                return Redirect(currentPage);
            }
        }
    }
}
