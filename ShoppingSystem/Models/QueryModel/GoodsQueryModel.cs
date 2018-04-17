using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models.QueryModel
{
    public class GoodsQueryModel
    {
        /// <summary>
        /// 产品主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// 已售数量
        /// </summary>
        public int SaleSum { get; set; }
    }
}