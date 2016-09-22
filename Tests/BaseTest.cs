using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simple_web_template.Models;

namespace Tests
{
    [TestClass]
    public class BaseTest
    {
        public BaseTest()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            UserDbInitializer initializer = new UserDbInitializer();
            initializer.Init();
        }
    }
}
