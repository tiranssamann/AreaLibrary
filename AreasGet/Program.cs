using System;
using GeometryLibrary;
namespace AreasGet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometryCalculator calculator = new GeometryCalculator();

            // Вычисление площади круга
            double circleRadius = 5.0;
            double circleArea = calculator.CalculateCircleArea(circleRadius);
            Console.WriteLine($"Площадь круга с радиусом {circleRadius} равна {circleArea}");

            // Вычисление площади треугольника
            double triangleSide1 = 3.0;
            double triangleSide2 = 4.0;
            double triangleSide3 = 5.0;
            double triangleArea = calculator.CalculateTriangleArea(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"Площадь треугольника со сторонами {triangleSide1}, {triangleSide2}, {triangleSide3} равна {triangleArea}");
        }
    }
}
