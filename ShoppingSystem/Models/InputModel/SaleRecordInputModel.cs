using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models.InputModel
{
    public class SaleRecordInputModel
    {
        [Display(Name = "售卖记录标识")]
        public int? Id { get; set; }

        /// <summary>
        /// 客户外键
        /// </summary>
        [Display(Name = "客户外键")]
        [Required(ErrorMessage = "客户外键不能为空")]
        public int UserId { get; set; }

        [Display(Name = "商品的售卖时间")]
        [Required(ErrorMessage = "商品的售卖时间不能为空")]

        public DateTime SaleTime { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [Display(Name = "商品的售卖总价格")]
        [Required(ErrorMessage = "商品的售卖总价格不能为空")]
        public Double SalePrice { get; set; }
    }
}