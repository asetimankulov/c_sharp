using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            (double r_circle, double s_circle) = CalculateCircle();
            Console.WriteLine($"Радиус круга = {r_circle}, площадь круга = {s_circle}");

            Console.WriteLine("Задача 2");
            (double p_rectangle, double s_rectangle) = CalculateRectangle();
            Console.WriteLine($"Периметр прямоугольника = {p_rectangle}, площадь прямоугольника = {s_rectangle}");

            Console.WriteLine("Задача 3");
            (double p_triangle, double s_triangle) = CalculateTriangle();
            Console.WriteLine($"Периметр треугольника = {p_triangle}, площадь треугольника = {s_triangle}");
            Console.ReadKey();
        }

        private static (double, double) CalculateCircle()
        {
            Console.WriteLine("Введите длину окружности");
            double l = double.Parse(Console.ReadLine());
            double r = CalculateCircleRadius(l);
            double s = CalculateCircleArea(r);
            return (r, s);
        }

        private static double CalculateCircleRadius(double l)
        {
            return (double)l / (2 * Math.PI);
        }

        private static double CalculateCircleArea(double r)
        {
            return Math.PI* Math.Pow(r, 2);
        }

        private static (double, double) ReadCoordinates(string prompt)
        {
            Console.WriteLine(prompt);
            var parts = Console.ReadLine().Split(',');
            return (double.Parse(parts[0]), double.Parse(parts[1]));
        }
        private static (double, double) CalculateRectangle()
        {
            (double x1, double y1) = ReadCoordinates("Введите через запятую координаты первой вершины");
            (double x2, double y2) = ReadCoordinates("Введите через запятую координаты второй вершины");
            double p = CalculateRectanglePerimeter(x1, y1, x2, y2);
            double s = CalculateRectangleArea(x1, y1, x2, y2);
            return (p, s);
        }
        private static double CalculateRectanglePerimeter(double x1, double y1, double x2, double y2)
        {
            return 2 * (x2 - x1 + y1 - y2);
        }

        private static double CalculateRectangleArea(double x1, double y1, double x2, double y2)
        {
            return (x2 - x1) * (y1 - y2);
        }
        private static (double, double) CalculateTriangle()
        {
            (double x1, double y1) = ReadCoordinates("Введите через запятую координаты первой вершины");
            (double x2, double y2) = ReadCoordinates("Введите через запятую координаты второй вершины");
            (double x3, double y3) = ReadCoordinates("Введите через запятую координаты третьей вершины");
            double a = CalculateDistance(x1, y1, x2, y2);
            double b = CalculateDistance(x2, y2, x3, y3);
            double c = CalculateDistance(x3, y3, x1, y1);
            double p = a + b + c;
            double s = CalculateTriangleArea(a, b, c);
            return (p, s);
        }
        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        private static double CalculateTriangleArea(double a, double b, double c)
        {
            double p = (double)(a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
