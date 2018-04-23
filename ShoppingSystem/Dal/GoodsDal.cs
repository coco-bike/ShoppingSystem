using ShoppingSystem.Models;
using ShoppingSystem.Models.InputModel;
using ShoppingSystem.Models.QueryModel;
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
        public int AddGoods(GoodsInputModel inputModel)
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
            int goodsId=0;
            if (result)
            {
                goodsId = goods.Id;
            }
            return goodsId;
        }
        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GoodsQueryModel GetGoods(string id)
        {
            var result = GoodsDb.GetById(id);
            GoodsQueryModel queryModel = new GoodsQueryModel()
            {
                AddTime=result.AddTime,
                Id=result.Id,
                Name=result.Name,
                Price=result.Price,
                SaleSum=result.SaleSum,
                Stock=result.Stock,
                UpdateTime=result.UpdateTime
            };
            return queryModel;
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
                PageCount = 0,
                PageIndex = page,
                PageSize = rows
            };
            var result = GoodsDb.GetPageList(s => s.State == 1, pageModel).OrderBy(s=>s.UpdateTime).Select(s => new GoodsQueryModel
            {
                AddTime = s.AddTime,
                Id = s.Id,
                Name = s.Name,
                Price = s.Price,
                SaleSum = s.SaleSum,
                Stock = s.Stock,
                UpdateTime = s.UpdateTime
            }).ToList();
            return new { total = pageModel.PageCount, rows = result };
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