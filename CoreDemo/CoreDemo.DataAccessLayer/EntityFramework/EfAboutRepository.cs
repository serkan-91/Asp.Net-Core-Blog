﻿using CoreDemo.DataAccessLayer.Abstract;
using CoreDemo.DataAccessLayer.DataContext;
using CoreDemo.DataAccessLayer.Repositories;
using CoreDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.DataAccessLayer.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
        public EfAboutRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
