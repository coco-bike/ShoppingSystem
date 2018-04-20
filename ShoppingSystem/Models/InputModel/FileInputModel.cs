using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models.InputModel
{
    public class FileInputModel
    {
        [Display(Name ="文件标识")]
        public int? Id { get; set; }

        [Display(Name ="文件标识")]
        [Required(ErrorMessage ="商品标识不能为空")]
        public int GoodsId { get; set; }

        [Display(Name = "文件的相对地址")]
        [Required(ErrorMessage = "文件的相对地址不能为空")]
        [StringLength(100,ErrorMessage ="最大长度不能超过100")]
        public string Url { get; set; }
        /// <summary>
        /// 0：代表缩略图,1：代表大图
        /// </summary>
        [Display(Name = "图片类型")]
        [Required(ErrorMessage = "图片类型不能为空")]
        public int Type { get; set; }

        [Display(Name = "添加时间")]
        [Required(ErrorMessage = "添加时间不能为空")]
        public DateTime AddTime { get; set; }

        [Display(Name = "更新时间")]
        [Required(ErrorMessage = "添加时间不能为空")]
        public DateTime UpdateTime { get; set; }

        [Display(Name = "文件状态")]
        [Required(ErrorMessage = "文件状态不能为空")]
        public int State { get; set; }
    }
}