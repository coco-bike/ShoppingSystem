using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models
{
    public class SonAdmin
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public long Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [SugarColumn(Length = 21)]
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [SugarColumn(Length = 50)]
        public string PassWord { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
    }
}