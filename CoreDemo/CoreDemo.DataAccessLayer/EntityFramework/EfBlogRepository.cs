using CoreDemo.DataAccessLayer.Abstract;
using CoreDemo.DataAccessLayer.DataContext;
using CoreDemo.DataAccessLayer.Repositories;
using CoreDemo.DataAccessLayer.UOW;
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

        

        public List<Blog> GetBlogListWithCategory()
        {
            return dbSet.Include(x => x.Category).ToList();
        }
    }
}
