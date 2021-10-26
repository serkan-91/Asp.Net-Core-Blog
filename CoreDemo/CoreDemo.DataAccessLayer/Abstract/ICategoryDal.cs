using CoreDemo.Shared.Models;
using CoreDemo.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericRepository<Category>
    {
      
    }
}
