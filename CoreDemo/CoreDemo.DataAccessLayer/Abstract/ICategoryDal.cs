using CoreDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetCategories();
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategoryById(int id);
    }
}
