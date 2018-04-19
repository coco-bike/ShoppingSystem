using ShoppingSystem.Models;
using ShoppingSystem.Models.InputModel;
using ShoppingSystem.SqlSugar;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Dal
{
    public class GoodsDal:DbContext
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool AddGoods(GoodsInputModel inputModel)
        {
            Goods goods = new Goods()
            {
                AddTime = DateTime.Now,
                Name = inputModel.Name,
                Price = inputModel.Price,
                SaleSum = 0,
                State = 1,
                Stock = inputModel.Stock,
                Type = inputModel.Type,
                UpdateTime = DateTime.Now
            };
            var result = GoodsDb.Insert(goods);
            return result;
        }
        /// <summary>
        /// 获取商品分页
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public object GetGoodsPageList(int page,int rows)
        {
            PageModel pageModel = new PageModel()
            {
                PageCount = rows,
                PageIndex = page,
                PageSize = 0
            };
            List<Goods> goods = new List<Goods>();
            var result = GoodsDb.GetPageList(s=>s.State==1,pageModel);
            return new { total = pageModel.PageSize, list = result };
        }
        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool UpdateGoods(GoodsInputModel inputModel)
        {
            Goods goods = new Goods()
            {
                Id=inputModel.Id,
                Name = inputModel.Name,
                Price = inputModel.Price,
                SaleSum = inputModel.SaleSum,
                State = inputModel.State,
                Stock = inputModel.Stock,
                Type = inputModel.Type,
                UpdateTime = DateTime.Now,
            };
            var result = GoodsDb.Update(goods);
            return result;
        }
        /// <summary>
        /// 删除商品（真删）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool TrueDeleteGoods(string id)
        {
            var result = GoodsDb.DeleteById(id);
            return result;
        }
        /// <summary>
        /// 删除商品（假删）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool FalseDeleteGoods(string id)
        {
            var entity = GoodsDb.GetById(id);
            entity.State = 0;
            var result = GoodsDb.Update(entity);
            return result;
        }
    }
}