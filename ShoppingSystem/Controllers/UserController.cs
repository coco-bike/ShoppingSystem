using ShoppingSystem.Dal;
using ShoppingSystem.Models.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDal userDal;
        public UserController()
        {
            userDal = new UserDal();
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public ActionResult RegisterUser(UserInputModel inputModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = userDal.AddUser(inputModel);
                    return result ? Json("注册成功") : Json("注册失败");
                }
                else
                {
                    return Json("注册失败");
                }
            }
            catch (Exception ex)
            {
                return Json(ex);
            }

        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ActionResult GetUserPageList(int page,int rows)
        {
            try
            {

                var result = userDal.GetUserPageList(page, rows);
                return Json(result);
            }
            catch(Exception ex)
            {
                return Json(ex);
            }
        }
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public ActionResult UpdateUser(UserInputModel inputModel)
        {
            try
            {
                var result = userDal.UpdateUser(inputModel);
                return result ? Json("更新成功") : Json("更新失败");

            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteUser(string id)
        {
            try
            {
                var result = userDal.DeleteUser(id);
                return result ? Json("删除成功") : Json("删除失败");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}