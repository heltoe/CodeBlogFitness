using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Arrenge
            var userName = Guid.NewGuid().ToString();
            var birthday = DateTime.Now.AddYears(-18);
            var weigth = 90;
            var heigth = 180;
            var genger = "Мужской";
            // Act
            var controller = new UserController(userName);
            controller.SetNewUserData(genger, birthday, weigth, heigth);
            var controller2 = new UserController(userName);
            // Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(birthday, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(weigth, controller2.CurrentUser.Weight);
            Assert.AreEqual(heigth, controller2.CurrentUser.Height);
            Assert.AreEqual(genger, controller2.CurrentUser.Gender.Name);

        }

        [TestMethod()]
        public void SaveTest()
        {
            // Arrenge
            var userName = Guid.NewGuid().ToString();
            // Act
            var controller = new UserController(userName);
            // Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}