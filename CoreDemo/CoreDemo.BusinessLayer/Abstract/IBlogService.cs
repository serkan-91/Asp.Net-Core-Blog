using CoreDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog category);
        void BlogUpdate(Blog category);
        void BlogDelete(Blog category);
        List<Blog> GetBlogs();
        Blog GetBlogById(int id);
    }
}
