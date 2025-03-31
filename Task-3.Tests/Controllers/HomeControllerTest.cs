using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3;
using Task_3.Controllers;

namespace Task_3.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        // This is a test method for the Index method of the HomeController
        [TestMethod]
        public void Index()
        {
            // Arrange
            // Here we are initializing the HomeController
            HomeController controller = new HomeController();

            // Act
            // Here we are calling the Index method of the HomeController and storing the result in a variable with type ViewResult
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            // Here we are checking that the result is not null
            Assert.IsNotNull(result);

            //Here we are checking the ViewBag.Message is equal to "Hello, World!"
            Assert.AreEqual("Hello, World!", result.ViewBag.Message);

        }

    
    }
}
