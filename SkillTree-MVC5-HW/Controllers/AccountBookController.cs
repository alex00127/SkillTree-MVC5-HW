using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC5_HW.Models.ViewModels;
using SkillTree_MVC5_HW.Models;
using SkillTree_MVC5_HW.Models.Service;

namespace SkillTree_MVC5_HW.Controllers
{
    public class AccountBookController : Controller
    {
        private readonly AccountBookService _accountBookService ;

        public AccountBookController()
        {
            _accountBookService = new AccountBookService();
        }

        // GET: AccountBook
        public ActionResult AccountBook()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildAction()
        {

   
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
            return View(_accountBookService.Lookup());
        }
    }
}