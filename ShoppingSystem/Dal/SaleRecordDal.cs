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
    public class SaleRecordDal:DbContext
    {
        /// <summary>
        /// 添加售卖记录
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool AddSaleRecord(SaleRecordInputModel inputModel)
        {
            SaleRecord saleRecord = new SaleRecord()
            {
                SalePrice=inputModel.SalePrice,
                SaleTime=DateTime.Now,
                UserId=inputModel.UserId
            };
            var result = SaleRecordDb.Insert(saleRecord);
            return result;
        }
        /// <summary>
        /// 获取售卖记录
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public object GetSaleRecordsPageList(int page,int rows,int userId)
        {
            PageModel pageModel = new PageModel()
            {
                PageCount = 0,
                PageIndex = page,
                PageSize = rows
            };
            var result = SaleRecordDb.GetPageList(s => s.UserId == userId, pageModel).OrderBy(s => s.SaleTime).Select(s => new SaleRecordQueryModel
            {
                Id = s.Id,
                SalePrice = s.SalePrice,
                SaleTime = s.SaleTime,
                UserId = s.UserId
            }).ToList();
            return new { total = pageModel.PageCount, rows = result };
        }
    }
}