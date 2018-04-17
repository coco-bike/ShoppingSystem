using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models
{
    public class Goods
    {
        /// <summary>
        /// 产品主键
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [SugarColumn(Length = 21)]
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
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        
    }
}