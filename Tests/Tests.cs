using CityPopulateApp.Controllers;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityPopulateApp.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GetJsonData_Test()
        {
            using (ShimsContext.Create())
            {
                HomeController controller = new HomeController();
                var result = controller.GetJsonData();
                Assert.IsTrue(result.Data!=null);
            }
        }
    }
}