using ShoppingSystem.Models;
using ShoppingSystem.SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SqlSugar;

namespace ShoppingSystem.Dal
{
    public class GoodsSaleDal : DbContext
    {
        /// <summary>
        /// 添加商品售卖记录
        /// </summary>
        /// <param name="goods_Sale"></param>
        /// <returns></returns>
        public bool AddGoodsSale(Goods_Sale goods_Sale)
        {
            var result = GoodsSaleDb.Insert(goods_Sale);
            return result;
        }
        /// <summary>
        /// 获取绑定记录
        /// </summary>
        /// <param name="goodId"></param>
        /// <param name="saleId"></param>
        /// <returns></returns>
        public List<Goods_Sale> GetGoods_Sale(string goodId, string saleId)
        {
            if (string.IsNullOrEmpty(goodId) && string.IsNullOrEmpty(saleId))
            {
                throw new ArgumentException("参数为空");
            }
            else if (string.IsNullOrEmpty(goodId) && !string.IsNullOrEmpty(saleId))
            {
                var saleIdInt = Convert.ToInt32(saleId);
                var result = GoodsSaleDb.GetList(s => s.SaleRecordId == saleIdInt);
                return result;
            }
            else
            {
                var goodIdInt = Convert.ToInt32(goodId);
                var result = GoodsSaleDb.GetList(s => s.GoodsId == goodIdInt);
                return result;
            }
        }
    }
}