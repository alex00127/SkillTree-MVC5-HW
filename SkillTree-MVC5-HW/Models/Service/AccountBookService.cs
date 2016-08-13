using SkillTree_MVC5_HW.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillTree_MVC5_HW.Repositories;

namespace SkillTree_MVC5_HW.Models.Service
{
    public class AccountBookService : Repository<AccountBook>
    {
        private readonly Irepository<AccountBook> _accountBookRep;

        public AccountBookService(IUnitOfWork unitOfWork): base(unitOfWork)
        {
            _accountBookRep = new Repository<AccountBook>(unitOfWork);
        }
        
        public IEnumerable<AccountBookViewModels> LookUpAll()
        {
            var accountBooks = _accountBookRep.LookupAll();
            var result = accountBooks.AsEnumerable()
            .Select(a => new AccountBookViewModels()
                {
                    Category = a.Categoryyy == 0 ? CategoryEnum.Expand : CategoryEnum.Income,
                    Date = a.Dateee,
                    Amount = a.Amounttt,
                    Description = a.Remarkkk
                }).ToList();
            return result;
        }

        //public List<AccountBookViewModels> Lookup()
        //{
            //var model = _db.AccountBook
                //.Select(a => new AccountBookViewModels
                //{
                    //Category = a.Categoryyy == 0 ? CategoryEnum.支出 : CategoryEnum.收入,
                    //Date = a.Dateee,
                    //Amount = a.Amounttt,
                    //Description = a.Remarkkk
                //}).ToList();
            //return model;
        //}
    }
}