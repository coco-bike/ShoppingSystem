using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models.InputModel
{
    public class UserInputModel
    {
        [Display(Name = "客户的主键")]
        public int? Id { get; set; }

        [Display(Name = "客户的昵称")]
        public string Name { get; set; }

        [Display(Name = "客户电子邮件")]
        [Required(ErrorMessage = "客户电子邮件不能为空")]
        public string Email { get; set; }

        [Display(Name = "客户电子邮件")]
        [Required(ErrorMessage = "密码不能为空")]
        [RegularExpression("",ErrorMessage ="")]
        public string PassWord { get; set; }
        /// <summary>
        /// 类型：0 普通用户,1 VIP用户
        /// </summary>

        [Display(Name = "客户类型")]
        public int Type { get; set; }

        [Display(Name = "收货地址")]
        public string Address { get; set; }

        [Display(Name = "客户注册时间")]
        [Required(ErrorMessage = "客户注册时间不能为空")]
        public DateTime RegisterTime { get; set; }


        [Display(Name = "更新时间")]
        [Required(ErrorMessage = "客户更新时间不能为空")]
        public DateTime UpdateTime { get; set; }

        [Display(Name = "客户的状态")]
        [Required(ErrorMessage = "客户的状态不能为空")]
        public int State { get; set; }
    }
}