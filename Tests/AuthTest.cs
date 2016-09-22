using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simple_web_template.Common;
using simple_web_template.Models;
using simple_web_template.Models.Operations;

namespace Tests
{
    [TestClass]
    public class AuthTest : BaseTest
    {

        [TestMethod]
        public void CheckPassword_Test()
        {
            var p1 = "123456";
            var p2 = "123456".ToMd5();
            Assert.IsTrue(LoginOperations.CheckPassword(p1, p2));
        }

        [TestMethod]
        public void Auth_Test()
        {
            LoginOperations loginOperations = new LoginOperations(new AppDbContext());
            var user = loginOperations.Authentificate("navff@gmail.com", "123456");
            Assert.AreEqual("navff@gmail.com", user.Email);
        }

        [TestMethod]
        public void Auth_WrongPassword_Test()
        {
            LoginOperations loginOperations = new LoginOperations(new AppDbContext());
            var user = loginOperations.Authentificate("navff@gmail.com", "1234567");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void Auth_WrongEmail_Test()
        {
            LoginOperations loginOperations = new LoginOperations(new AppDbContext());
            var user = loginOperations.Authentificate("pipiska@gmail.com", "123456");
            Assert.IsNull(user);
        }
    }
}
