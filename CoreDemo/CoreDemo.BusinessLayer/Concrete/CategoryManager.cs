using CoreDemo.BusinessLayer.Abstract;
using CoreDemo.DataAccessLayer.Abstract;
using CoreDemo.DataAccessLayer.DataContext;
using CoreDemo.DataAccessLayer.EntityFramework;
using CoreDemo.DataAccessLayer.Repositories;
using CoreDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly  ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {

            _categoryDal.Add(category);
          
        }

        public void CategoryDelete(Category category)
        {

            _categoryDal.Delete(category);
            
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);

        }

        public List<Category> GetCategories()
        {
          return _categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
          return _categoryDal.GetById(id);
        }
    }
}
