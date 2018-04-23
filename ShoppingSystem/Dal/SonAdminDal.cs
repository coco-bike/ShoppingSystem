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
    public class SonAdminDal : DbContext
    {
        /// <summary>
        /// 添加子管理员
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool AddSonAdmin(SonAdminInputModel inputModel)
        {
            SonAdmin sonAdmin = new SonAdmin()
            {
                Name = inputModel.Name,
                PassWord = inputModel.PassWord,
                RegisterTime = DateTime.Now,
                State = 1,
                UpdateTime = DateTime.Now
            };
            var result = SonAdminDb.Insert(sonAdmin);
            return result;
        }
        /// <summary>
        /// 获取子管理员分类
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public object GetSonAdminPageList(int page, int rows)
        {
            PageModel pageModel = new PageModel()
            {
                PageCount = 0,
                PageIndex = page,
                PageSize = rows
            };
            var result = SonAdminDb.GetPageList(s => s.State == 1 && s.State == 0, pageModel).OrderBy(s => s.UpdateTime).Select(s => new SonAdminQueryModel
            {
                Id = s.Id,
                Name = s.Name,
                PassWord = s.PassWord,
                RegisterTime = s.RegisterTime,
                State = s.State,
                UpdateTime = s.UpdateTime
            }).ToList();
            return new { total = pageModel.PageCount, rows = result };
        }
        /// <summary>
        /// 更改账户
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool UpdateSonAdmin(SonAdminInputModel inputModel)
        {
            var entity = SonAdminDb.GetById(inputModel.Id);

            entity.Name = inputModel.Name;
            entity.PassWord = inputModel.PassWord;
            entity.State = inputModel.State;
            entity.UpdateTime = DateTime.Now;

            var result = SonAdminDb.Update(entity);
            return result;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteSonAdmin(int id)
        {
            var entity = SonAdminDb.GetById(id);
            entity.State = 1;
            var result = SonAdminDb.Update(entity);
            return result;
        }
    }
}