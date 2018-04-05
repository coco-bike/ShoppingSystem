using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingSystem.Dal;
using ShoppingSystem.Models;

namespace ShoppingSystem.Tests.Controllers
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void Add()
        {
            //准备
            UserDal userDal = new UserDal();
            User user = new User()
            {
                Address="asdasdsads",
                Email="asdasdsadads",
                Name="adsasdadsad",
                PassWord="asdasd",
                RegisterTime=DateTime.Now,
                State=1,
                Type=1,
                UpdateTime=DateTime.Now
            };
            //动作
           var res =  userDal.AddUser(user);
            //断言
            Assert.IsTrue(res);
        }
    }
}
