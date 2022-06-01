using System;

namespace Lesson11
{
    class Box
    {
        public double l, b, h;
        public Box(double le, double br, double he)
        {
            this.l = le;
            this.b = br;
            this.h = he;
        }
        public double Volume()
        {
            return l * b * h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(45,10,20);
            Console.WriteLine("Volume of box1 is: {0}", box1.Volume());

            Box box2 = new Box(34,50,50);
            Console.WriteLine("Volume of box1 is: {0}", box1.Volume());

        }
    }
}
