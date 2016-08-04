using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTree_MVC5_HW.Models.ViewModels
{
    public enum CategoryEnum { 支出, 收入 };
    public class AccountBookViewModels
    {
        public int Id { get; set; }
        public CategoryEnum Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}