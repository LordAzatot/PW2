using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle
    {
        private double side1, side2;

        // Конструктор
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Метод для обчислення площі
        public double CalculateArea() => side1 * side2;

        // Метод для обчислення периметра
        public double CalculatePerimeter() => 2 * (side1 + side2);

        // Властивість для площі
        public double Area => CalculateArea();

        // Властивість для периметра
        public double Perimeter => CalculatePerimeter();
    }

    class Program1
    {
        static void Main()
        {
            Console.Write("Введіть довжину першої сторони прямокутника: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть довжину другої сторони прямокутника: ");
            double side2 = double.Parse(Console.ReadLine());

            var rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площа прямокутника: {rectangle.Area:F2}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter:F2}");
        }
    }
}