using CoreDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> GetBlogs();
        void AddBlog(Blog blog);
        void RemoveBlog(Blog blog);
        void UpdateBlog(Blog blog);
        Category GetBlogById(int id);
    }
}
