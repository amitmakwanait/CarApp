using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using LosFusion.CarAppWebApi;
using LosFusion.CarAppWebApi.Controllers;
using LosFusion.CarAppWebApi.Models;

namespace LosFusion.CarAppWebApi.Tests.Controllers
{
    [TestClass]
    public class ManageCarDetailsControllerest
    {
        [TestMethod]
        public void GetByYear()
        {
            // Arrange
            var controller = new ManageCarDetailsController(new TestUnitTestMockingConext());

            // Act
            var result =controller.GetByYear("2019");

            // Assert
            Assert.IsNotNull(result);
            
       
        }

        [TestMethod]
        public void GetByName()
        {
            // Arrange
            var controller = new ManageCarDetailsController(new TestUnitTestMockingConext());

            // Act
            var result = controller.GetByName("Test");

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            CarModel model = new CarModel();
            var controller = new ManageCarDetailsController(new TestUnitTestMockingConext());
            model.Name = "Test";
            model.Color = "Red";
            model.YearMade = "2021";

            // Act
          var result=  controller.Post(model);
            // Assert
            Assert.IsNotNull(result);

        }
 
    }
}
