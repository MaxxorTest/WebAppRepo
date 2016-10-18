using System.Web.Mvc;
using SampleWebApplication.Controllers;
using Xunit;


namespace SampleWebApplication.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void About()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.Equal("Your application description page.", result.ViewBag.Message);
        }

        [Fact]
        public void Contact()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
