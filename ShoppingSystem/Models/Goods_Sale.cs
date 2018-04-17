using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models
{
    public class Goods_Sale
    {
        /// <summary>
        /// 商品外键
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public int GoodsId { get; set; }

        [SugarColumn(IsNullable = false)]
        public int SaleRecordId { get; set; }

        [SugarColumn(IsNullable = false)]
        public int SaleSum { get; set; }
    }
}