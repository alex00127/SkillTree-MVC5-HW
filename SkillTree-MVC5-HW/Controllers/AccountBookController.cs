﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC5_HW.Models.ViewModels;

namespace SkillTree_MVC5_HW.Controllers
{
    public class AccountBookController : Controller
    {
        // GET: AccountBook
        public ActionResult AccountBook()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildAction()
        {
            var model = new AccountBookViewModels
            {
                Id = 1,
                Category = "",
                Date = DateTime.Now,
                Amount = 200,
                Description = "hello!"
            }
            ;
            return View(model);
        }
    }
}