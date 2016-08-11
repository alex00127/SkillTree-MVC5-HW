using SkillTree_MVC5_HW.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTree_MVC5_HW.Models.Service
{
    public class AccountBookService
    {
        private Model1 _db;

        public AccountBookService()
        {
            _db = new Model1();
        }

        public List<AccountBookViewModels> Lookup()
        {
            var model = _db.AccountBook
                .Select(a => new AccountBookViewModels
                {
                    Category = a.Categoryyy == 0 ? CategoryEnum.支出 : CategoryEnum.收入,
                    Date = a.Dateee,
                    Amount = a.Amounttt,
                    Description = a.Remarkkk
                }).ToList();
            return model;
        }
    }
}