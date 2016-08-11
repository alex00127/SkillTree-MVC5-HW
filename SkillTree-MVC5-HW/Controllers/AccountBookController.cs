using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC5_HW.Models.ViewModels;
using SkillTree_MVC5_HW.Models;

namespace SkillTree_MVC5_HW.Controllers
{
    public class AccountBookController : Controller
    {
        private Model1 db = new Model1();
        // GET: AccountBook
        public ActionResult AccountBook()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildAction()
        {
            var model = db.AccountBook
                .Select(a => new AccountBookViewModels
                {
                    //Id = BitConverter.ToInt32(a.Id.ToByteArray(),0),
                    Category = a.Categoryyy == 0 ? CategoryEnum.支出 : CategoryEnum.收入,
                    Date = a.Dateee,
                    Amount = a.Amounttt,
                    Description = a.Remarkkk

                }).ToList();
   
            //var model = new List<AccountBookViewModels> {
            //new AccountBookViewModels()
            //{
                //Id = 1,
                //Category = CategoryEnum.支出 ,
               // Date = DateTime.Now,
               // Amount = 100,
                //Description = "買飲料"
            //} };
            //,
            //new AccountBookViewModels()
            //{
                //Id = 2,
                //Category = CategoryEnum.支出 ,
                //Date = DateTime.Now.AddDays(2),
                //Amount = 200,
                //Description = "吃飯"
            //},
            //new AccountBookViewModels()
            //{
                //Id = 3,
                //Category = CategoryEnum.收入 ,
                //Date = DateTime.Now.AddDays(3),
                //Amount = 500,
                //Description = "打工"
            //}};
            return View(model);
        }
    }
}