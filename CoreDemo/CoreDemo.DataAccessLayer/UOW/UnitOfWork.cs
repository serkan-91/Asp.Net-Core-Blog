using CoreDemo.DataAccessLayer.Abstract;
using CoreDemo.DataAccessLayer.DataContext;
using CoreDemo.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccessLayer.UOW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        public ICategoryDal Categories { get; private set; }
        public IBlogDal Blogs { get; private set; }
        public IAboutDal Abouts { get; private set; }
        public ICommentDal Comments { get; private set; }
        public IContactDal Contacts { get; private set; }
        public IWriterDal Writers { get; private set; }

   

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Categories = new EfCategoryRepository(_context);
            Blogs = new EfBlogRepository(_context);
            Abouts = new EfAboutRepository(_context);
            Comments = new EfCommentRepository(_context);
            Contacts = new EfContactRepository(_context);
            Writers = new EfWriterRepository(_context);
        }


       

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
