using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models
{
    public class File
    {
        /// <summary>
        ///主键Id
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public long Id { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// 文件地址
        /// </summary>
        [SugarColumn(Length = 100)]
        public string Url { get; set; }
        /// <summary>
        /// 0：代表缩略图,1：代表大图
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpTime { get; set; }
    }
}