using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models.InputModel
{
    public class SonAdminInputModel
    {

        [Display(Name = "子管理员主键")]
        public int? Id { get; set; }

        [Display(Name = "子管理员名称")]
        [Required(ErrorMessage = "子管理员名称不能为空")]
        public string Name { get; set; }

        [Display(Name = "子管理员密码")]
        [Required(ErrorMessage = "子管理员密码不能为空")]
        public string PassWord { get; set; }

        [Display(Name = "注册时间")]
        [Required(ErrorMessage = "注册时间不能为空")]
        public DateTime RegisterTime { get; set; }

        [Display(Name = "更新时间")]
        [Required(ErrorMessage = "更新时间不能为空")]
        public DateTime UpdateTime { get; set; }

        [Display(Name = "状态")]
        [Required(ErrorMessage = "状态不能为空")]
        public int State { get; set; }
    }
}