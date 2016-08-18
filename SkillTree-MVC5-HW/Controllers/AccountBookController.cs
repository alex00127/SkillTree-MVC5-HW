using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC5_HW.Models.ViewModels;
using SkillTree_MVC5_HW.Models;
using SkillTree_MVC5_HW.Models.Service;
using SkillTree_MVC5_HW.Repositories;

namespace SkillTree_MVC5_HW.Controllers
{
    public class AccountBookController : Controller
    {
        private readonly AccountBookService _accountBookService ;

        public AccountBookController()
        {
            var unitOfWork = new EFUnitOfWork();
            _accountBookService = new AccountBookService(unitOfWork);
        }

        // GET: AccountBook
        public ActionResult AccountBook()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New([Bind(Include = "Category,Amount,Date,Description")] AccountBookViewModels accountBook)
        {
            
            _accountBookService.Add(accountBook);
            _accountBookService.Save();

            System.Threading.Thread.Sleep(5000);
            //ViewData["record"] = accountBook;
            return View(accountBook);
        }

        [ChildActionOnly]
        public ActionResult AccountBookList()
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
            var result = _accountBookService.LookUpAll();
            return View(result);


        }
    }
}