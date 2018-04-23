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
    public class FileDal:DbContext
    {
        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool AddFile(FileInputModel inputModel)
        {
            File file = new File()
            {
                AddTime = DateTime.Now,
                GoodsId = inputModel.GoodsId,
                State = inputModel.State,
                Type = inputModel.Type,
                UpdateTime = DateTime.Now,
                Url = inputModel.Url
            };
            var result = FileDb.Insert(file);
            return result;
        }
        /// <summary>
        /// 获取单个商品的大图和缩略图
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public List<FileQueryModel> GetFiles(string goodsId)
        {
            var goodsIdInt = Convert.ToInt32(goodsId);
            var result = FileDb.GetList(s => s.GoodsId == goodsIdInt && s.State == 1).Select(s=>new FileQueryModel{
                AddTime=s.AddTime,
                GoodsId=s.GoodsId,
                Id=s.Id,
                Type=s.Type,
                UpdateTime=s.UpdateTime,
                Url=s.Url
            }).ToList();
            return result;
        }

        /// <summary>
        /// 获取图片分页
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public object GetFilePageList(int page,int rows)
        {
            PageModel pageModel = new PageModel()
            {
                PageCount = 0,
                PageIndex = page,
                PageSize = rows
            };
            var result = FileDb.GetPageList(s => s.State == 1, pageModel).OrderBy(s => s.UpdateTime).Select(s => new FileQueryModel
            {
                AddTime = s.AddTime,
                GoodsId = s.GoodsId,
                Id = s.Id,
                Type = s.Type,
                UpdateTime = s.UpdateTime,
                Url = s.Url
            }).ToList();

            return new { total = pageModel.PageCount, rows = result };
        }

        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public bool UpdateFile(FileInputModel inputModel)
        {
            var entity = FileDb.GetById(inputModel.Id);
            entity.State = inputModel.State;
            entity.Type = inputModel.Type;
            entity.UpdateTime = DateTime.Now;
            entity.Url = inputModel.Url;
            var result = FileDb.Update(entity);
            return result;
        }
        /// <summary>
        /// 删除商品(假删)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteFile(string id)
        {
            var entity = FileDb.GetById(id);
            entity.State = 0;
            var result = FileDb.Update(entity);
            return result;
        }
    }
}