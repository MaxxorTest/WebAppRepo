using System.Runtime.InteropServices.ComTypes;
using System.Web.Mvc;
using SampleWebApplication.Classes;
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

        [Fact]
        public void Test()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Test() as ViewResult;

            // Assert
            Assert.NotNull(result);

        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(5,2,7)]
        [InlineData(3,2,5)]
        [InlineData(-3,2,-1)]
        public void ClassToAdd2Numbers(int n1, int n2, int ans)
        {
            // Arrange
            var classArith = new Arithmetic();
            
            //Act
            var res = classArith.Add2Numbers(n1, n2);

            //Assert
            Assert.Equal(ans, res);

        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(7,7,49)]
        [InlineData(25,25,625)]
        public void Multiply2Numbers(int n1, int n2, int ans)
        {
            // arrange
            var classArith = new Arithmetic();

            // act
            var ret = classArith.Multiply2Numbers(n1, n2);

            // assert
            Assert.Equal(ans, ret);
        }


    }
}
