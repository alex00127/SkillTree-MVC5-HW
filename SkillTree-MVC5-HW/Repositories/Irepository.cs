using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree_MVC5_HW.Repositories
{
    public interface Irepository<T> where T: class
    {
        IUnitOfWork UnitOfWork { get; set; }

        IQueryable<T> LookupAll();

    }
}
