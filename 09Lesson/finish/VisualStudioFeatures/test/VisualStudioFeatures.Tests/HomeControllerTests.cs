using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VisualStudioFeatures.Controllers;
using VisualStudioFeatures.Models;
using Xunit;

namespace VisualStudioFeatures.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;

            // Assert
            Assert.Equal(Repository.SharedRepository.GetProducts, model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
                    && p1.Price == p2.Price));
        }
    }
}