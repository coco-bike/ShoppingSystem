using ShoppingSystem.Dal;
using ShoppingSystem.Models.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSystem.Controllers
{
    public class SonAdminController : Controller
    {
        SonAdminDal sonAdmin = new SonAdminDal();

        // GET: SonAdmin
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加子管理员
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public ActionResult AddSonAdmin(SonAdminInputModel inputModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = sonAdmin.AddSonAdmin(inputModel);
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
        /// <summary>
        /// 获取子管理员列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ActionResult GetSonAdmin(int page,int rows)
        {
            try
            {
                var result = sonAdmin.GetSonAdminPageList(page, rows);
                return Json(result);
            }
            catch(Exception ex)
            {
                return Json(ex);

            }

        }
        /// <summary>
        /// 更新子管理员
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public ActionResult UpdateSonAdmin(SonAdminInputModel inputModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = sonAdmin.UpdateSonAdmin(inputModel);
                    return result ? Json("更新成功") : Json("更新失败");
                }
                else
                {
                    return Json("添加失败");
                }
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
        /// <summary>
        /// 删除子管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteSonAdmin(int id)
        {
            try
            {
                var result = sonAdmin.DeleteSonAdmin(id);
                return result ? Json("删除成功") : Json("删除失败");

            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}