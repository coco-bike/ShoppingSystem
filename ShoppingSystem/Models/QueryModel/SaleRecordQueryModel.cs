using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models.QueryModel
{
    public class SaleRecordQueryModel
    {
        /// <summary>
        /// 售卖记录主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 客户外键
        /// </summary>

        public int UserId { get; set; }
        /// <summary>
        /// 售卖时间
        /// </summary>

        public DateTime SaleTime { get; set; }
        /// <summary>
        /// 售卖价格
        /// </summary>

        public Double SalePrice { get; set; }
    }
}