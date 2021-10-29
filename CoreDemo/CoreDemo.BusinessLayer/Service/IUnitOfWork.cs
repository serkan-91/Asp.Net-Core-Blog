using CoreDemo.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.BusinessLayer.Service
{
    public interface IUnitOfWork
    {
        ICategoryDal Categories { get; }
        IBlogDal Blogs { get; }
        IAboutDal Abouts { get; }
        ICommentDal Comments { get; }
        IContactDal Contacts { get; }
        IWriterDal Writers { get; }
        INewsLetterDal NewsLetters { get; }
        Task CompleteAsync();

    }
}
