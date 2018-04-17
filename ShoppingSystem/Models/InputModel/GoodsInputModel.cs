using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models.InputModel
{
    public class GoodsInputModel
    {

        [Display(Name = "商品标识")]
        [Required(ErrorMessage = "添加时间不能为空")]
        public int Id { get; set; }

        [Display(Name = "商品名称")]
        [Required(ErrorMessage = "商品名称不能为空")]
        [StringLength(21,ErrorMessage ="商品名称的最大长度不能超过21个")]
        public string Name { get; set; }

        [Display(Name = "商品价格")]
        [Required(ErrorMessage = "商品价格不能为空")]
        public double Price { get; set; }

        [Display(Name = "商品上架时间")]
        [Required(ErrorMessage = "商品上架时间不能为空")]
        public DateTime AddTime { get; set; }

        [Display(Name = "商品更新时间")]
        [Required(ErrorMessage = "商品更新时间不能为空")]
        public DateTime UpdateTime { get; set; }

        [Display(Name = "商品库存数量")]
        [Required(ErrorMessage = "商品库存数量不能为空")]
        public int Stock { get; set; }

        [Display(Name = "商品已售数量")]
        [Required(ErrorMessage = "商品已售数量不能为空")]
        public int SaleSum { get; set; }

        [Display(Name = "商品状态")]
        [Required(ErrorMessage = "商品状态不能为空")]
        public int State { get; set; }
    }
}