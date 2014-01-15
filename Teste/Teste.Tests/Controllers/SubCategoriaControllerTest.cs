using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste.Controllers;

namespace Teste.Tests.Controllers
{
    [TestClass]
    public class SubCategoriaControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            SubCategoriaController controller = new SubCategoriaController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
