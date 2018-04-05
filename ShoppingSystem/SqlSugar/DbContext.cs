using ShoppingSystem.Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ShoppingSystem.SqlSugar
{
    public class DbContext
    {

        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString(),
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
            Db.CodeFirst.InitTables(typeof(File), typeof(Product),typeof(SaleRecord),typeof(SonAdmin),typeof(User));
        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作

        public DbSet<File> FileDb { get { return new DbSet<File>(Db); } }
        public DbSet<Product> ProductDb { get { return new DbSet<Product>(Db); } }
        public DbSet<SaleRecord> SaleRecordDb { get { return new DbSet<SaleRecord>(Db); } }
        public DbSet<SonAdmin> SonAdminDb { get { return new DbSet<SonAdmin>(Db); } }
        public DbSet<User> UserDb { get { return new DbSet<User>(Db); } }

    }
}