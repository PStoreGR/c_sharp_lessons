using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public String Color { get; set; }
        public String Made { get; set; }

        private static Random num = new Random();
        private int fuell = num.Next(100);

        public int Fuell
        {
            get { return fuell; }
            set { fuell = value; }
        }

        public Engine engine;
        public Car()
        {
            engine = new Engine();
        }

        public void Start()
        {
            Console.WriteLine($"My {Made} is running!!");
        }

        public void Stop()
        {
            Console.WriteLine($"My {Made} stopped!!");
        }
    }
}
