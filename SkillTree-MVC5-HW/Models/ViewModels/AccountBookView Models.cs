using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillTree_MVC5_HW.Models.ViewModels
{
    public enum CategoryEnum {
        [Display(Name="支出")]
        Expand,
        [Display(Name = "收入")]
        Income
    };
    public class AccountBookViewModels
    {
        public int Id { get; set; }
        public CategoryEnum Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}