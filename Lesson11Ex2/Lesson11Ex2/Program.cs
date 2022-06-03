using System;

namespace Lesson11Ex2
{
    class Program
    {
        class Circle
        {
            public double radius;

            public Circle()
            {
            }
            public Circle(double Radius)
            {
                radius = Radius;
            }
            public double Area()
            {
                return Math.PI * Math.Pow(radius,2);
            }
        }
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(2);

            Console.WriteLine($"Circle1 Area is {circle1.Area()}");
            Console.WriteLine($"Circle2 Area is {circle2.Area()}");
        }
    }
}
