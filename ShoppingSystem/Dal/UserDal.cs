using ShoppingSystem.Models;
using ShoppingSystem.SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Dal
{
    public class UserDal:DbContext
    {
        public bool AddUser(User user)
        {
            var result = UserDb.Insert(user);
            return result;
        }
    }
}