﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree_MVC5_HW.Repositories
{
    public interface Irepository<T> where T: class
    {
        /// <summary>
        /// unit of work
        /// </summary>
        IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        /// Lookups all
        /// </summary>
        /// <returns></returns>
        IQueryable<T> LookupAll();

        /// <summary>
        /// 新增一個entity
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);

        /// <summary>
        /// save change 
        /// </summary>
        void Commit();

    }
}
