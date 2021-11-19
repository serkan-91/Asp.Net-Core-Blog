using CoreDemo.DataAccessLayer.Abstract;
using CoreDemo.DataAccessLayer.DataContext;
using CoreDemo.DataAccessLayer.Repositories;
using CoreDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
    
        public EfBlogRepository(ApplicationDbContext context ) : base(context)
        {
            
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return dbSet.Where(x=> x.WriterId == id).ToList();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return dbSet.Include(x => x.Category).ToList();
        }

        public List<Blog> GetBlogListWithCategoryByWriter(int id)
        {
            return dbSet.Include(x => x.Category).Where(x => x.WriterId == id).ToList();

        }

        public List<Blog> GetLast3Blog()
        {
            return dbSet.Take(3).ToList();
        }
    }
}
