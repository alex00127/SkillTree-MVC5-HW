using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SkillTree_MVC5_HW.Repositories
{
    public class Repository<T> : Irepository<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get; set; }

        private DbSet<T> _Objectset;

        private DbSet<T> ObjectSet
        {
            get
            {
                if (_Objectset == null)
                {
                    _Objectset = UnitOfWork.Context.Set<T>();
                }
                return _Objectset;
            }
        }

        public Repository(IUnitOfWork unitofWork)
        {
            UnitOfWork = unitofWork;
        }

        public IQueryable<T> LookupAll()
        {
            return ObjectSet;
        }

        public void Create(T entity)
        {
            ObjectSet.Add(entity);
        }

        public void Commit()
        {
            UnitOfWork.Save();
        }
    }
}