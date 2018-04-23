using ShoppingSystem.Dal.SqlTransaction;
using ShoppingSystem.Models.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSystem.Controllers
{
    public class GoodsController : Controller
    {
        ShoppingSqlTransaction shoppingSql = new ShoppingSqlTransaction();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="goodsInput"></param>
        /// <param name="fileInput"></param>
        /// <returns></returns>
        public ActionResult AddGoods(GoodsInputModel goodsInput,FileInputModel fileInput)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = shoppingSql.AddGoods(goodsInput, fileInput);
                    return result ? Json("添加成功") : Json("添加失败");
                }
                else
                {
                    return Json("添加失败");
                }
            }
            catch(Exception ex)
            {
                return Json(ex);
            }
           
        
        }

    }
}