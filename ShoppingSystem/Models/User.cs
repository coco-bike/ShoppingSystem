using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models
{
    public class User
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [SugarColumn(Length = 21, IsNullable = true)]
        public string Name { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        [SugarColumn(Length = 50)]
        public string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [SugarColumn(Length = 50)]
        public string PassWord { get; set; }
        /// <summary>
        /// 类型：0 普通用户,1 VIP用户
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public int Type { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        [SugarColumn(Length = 50, IsNullable = true)]
        public string Address { get; set; }
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