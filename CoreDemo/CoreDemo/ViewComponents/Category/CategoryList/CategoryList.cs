using Microsoft.AspNetCore.Mvc;
using CoreDemo.BusinessLayer.Service;

namespace CoreDemo.ViewComponents.Category.CategoryList
{
    public class CategoryList : ViewComponent
    {
      private readonly  IUnitOfWork _uow;

        public CategoryList(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IViewComponentResult Invoke()
        {
            var values = _uow.Categories.GetAll();
            return View(values);
        }
        
    }
}
