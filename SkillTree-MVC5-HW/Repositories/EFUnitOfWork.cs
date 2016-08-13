using SkillTree_MVC5_HW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SkillTree_MVC5_HW.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public DbContext Context{ get; set; }

        public EFUnitOfWork()
        {
            Context = new Model1();
        }
        public void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}