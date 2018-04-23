using ShoppingSystem.Models.InputModel;
using ShoppingSystem.SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Dal.SqlTransaction
{
    public class ShoppingSqlTransaction: DbContext
    {
        private readonly GoodsDal goodsDal;
        private readonly FileDal fileDal;

        public ShoppingSqlTransaction()
        {
            goodsDal = new GoodsDal();
            fileDal = new FileDal();
        }

        public bool AddGoods(GoodsInputModel goodsInput,FileInputModel fileInput)
        {
            //Db.Ado.UseTran(() =>
            //{
            //});
            try
            {
                Db.Ado.BeginTran();
                var goodsId = goodsDal.AddGoods(goodsInput);
                fileInput.GoodsId = goodsId;
                var result = fileDal.AddFile(fileInput);
                Db.Ado.CommitTran();
            }
            catch (Exception ex)
            {
                Db.Ado.RollbackTran();
                throw ex;
            }
            return true;
        }



    }
}