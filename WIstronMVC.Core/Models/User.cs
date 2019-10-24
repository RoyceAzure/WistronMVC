using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WistronMVC.Core.Models;

namespace WistronMVC.Core.Models
{

        public class User : BaseUser
        {
            [EmailAddress]
            [Required]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Required]
            [Display(Name = "姓名")]
            public string Name { get; set; }
            [Required]
            [Display(Name = "英文姓名")]
            public string EnName { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }
            [Required]
            [Display(Name = "部門")]
            public string Dep { get; set; }
            [Required]
            [Display(Name = "工號")]
            public string WorkNumber { get; set; }
            [Required]
            [Display(Name = "確認密碼")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "密碼不一致")]
            public string ConfirmPas { get; set; }
            [Required]
            [Display(Name = "行動電話")]
            public string MobelPhone { get; set; }
            [Required]
            [Display(Name = "辦公電話")]
            public string TelPhone { get; set; }

            public string Image { get; set; }
            public User() : base()
            {

            }

        }
   

}
