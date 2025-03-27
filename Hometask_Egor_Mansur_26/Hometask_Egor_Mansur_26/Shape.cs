using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Task3
    {
        public static void Execute()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(5, 10),
                new Circle(7)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Площадь {shape.GetType().Name}: {shape.CalculateArea()}");
            }
        }
    }
}
