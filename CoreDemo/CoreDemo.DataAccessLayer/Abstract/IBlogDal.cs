using CoreDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericRepository<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListWithCategoryByWriter(int id);
        List<Blog> GetLast3Blog();
        List<Blog> GetBlogListByWriter(int id);
     
        
    }
}
