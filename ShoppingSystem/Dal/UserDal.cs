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
    public class UserDal:DbContext
    {
        /// <summary>
        /// 注册客户
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool AddUser(UserInputModel  inputModel)
        {
            User user = new User()
            {
                Address = inputModel.Address,
                Email=inputModel.Email,
                Name=inputModel.Name,
                PassWord=inputModel.PassWord,
                RegisterTime=DateTime.Now,
                State=1,
                Type=inputModel.Type,
                UpdateTime=DateTime.Now
            };
            var result = UserDb.Insert(user);
            return result;
        }
        /// <summary>
        /// 获取客户分页
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public object GetUserPageList(int page,int rows)
        {
            PageModel pageModel = new PageModel()
            {
                PageCount = 0,
                PageIndex = page,
                PageSize = rows
            };
            var result = UserDb.GetPageList(s => s.State == 1 && s.State == 0, pageModel).OrderBy(s => s.RegisterTime).Select(s => new UserQueryModel
            {
                Id=s.Id,
                Address = s.Address,
                Email = s.Email,
                Name = s.Name,
                PassWord = s.PassWord,
                RegisterTime = s.RegisterTime,
                Type = s.Type,
                UpdateTime = s.UpdateTime
            }).ToList();
            return new { total = pageModel.PageSize, rows = result };
        }
        /// <summary>
        /// 更新客户信息
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool UpdateUser(UserInputModel inputModel)
        {
            User user = new User()
            {
                Address = inputModel.Address,
                Email = inputModel.Email,
                Name = inputModel.Name,
                PassWord = inputModel.PassWord,
                RegisterTime =inputModel.RegisterTime,
                State = inputModel.State,
                Type = inputModel.Type,
                UpdateTime = DateTime.Now
            };
            var result = UserDb.Update(user);
            return result;
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteUser(string id)
        {
            var entity = UserDb.GetById(id);
            entity.State = 1;
            var result = UserDb.Update(entity);
            return result;
        }
    }
}