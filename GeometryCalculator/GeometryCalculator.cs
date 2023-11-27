using System;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        public double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        public double CalculateTriangleArea(double side1, double side2, double side3)
        {
            if (!IsTriangleValid(side1, side2, side3))
            {
                throw new ArgumentException("Невозможно построить треугольник с заданными сторонами.");
            }

            // Используем полупериметр и формулу Герона для вычисления площади треугольника
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        private bool IsTriangleValid(double side1, double side2, double side3)
        {
            // Проверяем неравенство треугольника: сумма двух сторон должна быть больше третьей стороны
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }
    }
}
