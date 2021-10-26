using CoreDemo.BusinessLayer.Abstract;
using CoreDemo.DataAccessLayer.Abstract;
using CoreDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.BusinessLayer.Concrete
{
    internal class BlogManager: IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog category)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog category)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog category)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogs()
        {
            return _blogDal.GetAll();
        }
    }
}
