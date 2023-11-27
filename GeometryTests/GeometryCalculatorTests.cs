using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryTests
{
    [TestClass]
    public class GeometryCalculatorTests
    {
        [TestMethod]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            GeometryCalculator calculator = new GeometryCalculator();
            double radius = 3.0;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = calculator.CalculateCircleArea(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Предоставляем небольшой допуск для плавающей точки
        }

        [TestMethod]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            GeometryCalculator calculator = new GeometryCalculator();
            double side1 = 4.0;
            double side2 = 5.0;
            double side3 = 6.0;
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            // Act
            double actualArea = calculator.CalculateTriangleArea(side1, side2, side3);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CalculateCircleArea_InvalidRadius_ThrowsArgumentException()
        {
            // Arrange
            GeometryCalculator calculator = new GeometryCalculator();
            double invalidRadius = -1.0;

            // Act
            double result = calculator.CalculateCircleArea(invalidRadius); // Также можно использовать Assert.ThrowsException, начиная с MSTest v2
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CalculateTriangleArea_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            GeometryCalculator calculator = new GeometryCalculator();
            double invalidSide1 = 2.0;
            double invalidSide2 = 3.0;
            double invalidSide3 = 7.0;

            // Act
            double result = calculator.CalculateTriangleArea(invalidSide1, invalidSide2, invalidSide3);
        }
    }
}
