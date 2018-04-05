using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models
{
    public class SaleRecord
    {
        /// <summary>
        /// 售卖记录主键
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public long Id { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public long ProductId { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        [SugarColumn(IsNullable = false)]

        public long UserId { get; set; }
        /// <summary>
        /// 售卖时间
        /// </summary>
        [SugarColumn(IsNullable = false)]

        public DateTime SaleTime { get; set; }
        /// <summary>
        /// 售卖数量
        /// </summary>
        [SugarColumn(IsNullable = false)]

        public int SaleSum { get; set; }
        /// <summary>
        /// 售卖价格
        /// </summary>
        [SugarColumn(IsNullable = false)]

        public Double SalePrice { get; set; }
    }
}