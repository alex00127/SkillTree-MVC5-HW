using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTree_MVC5_HW.Models.ViewModels
{
    public class AccountBook
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}