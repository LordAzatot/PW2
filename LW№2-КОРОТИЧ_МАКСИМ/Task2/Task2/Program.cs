using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Point
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }

        // Конструктор
        public Point(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }

    class Figure
    {
        private Point[] points;

        // Конструктор для 3-5 точок
        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                throw new ArgumentException("Багатокутник повинен мати від 3 до 5 точок.");
            }
            this.points = points;
        }

        // Метод для розрахунку довжини сторони
        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        // Метод для розрахунку периметра
        public double CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length]; // Замикання багатокутника
                perimeter += GetSideLength(current, next);
            }

            return perimeter;
        }

        // Властивість для отримання назви
        public string Name => points.Length switch
        {
            3 => "Трикутник",
            4 => "Чотирикутник",
            5 => "П'ятикутник",
            _ => "Невідомий багатокутник"
        };
    }

    class Program2
    {
        static void Main()
        {
            // Створюємо точки
            var A = new Point(0, 0, "A");
            var B = new Point(0, 3, "B");
            var C = new Point(4, 0, "C");

            // Створюємо трикутник
            var triangle = new Figure(A, B, C);

            Console.WriteLine($"Назва багатокутника: {triangle.Name}");
            Console.WriteLine($"Периметр багатокутника: {triangle.CalculatePerimeter():F2}");

            // Додатково можна створити чотирикутник чи п'ятикутник
        }
    }
}