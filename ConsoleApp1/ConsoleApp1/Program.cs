using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ob1 = new Car();

            ob1.Made = "BMW";

            Console.WriteLine(ob1.Fuell);
            Console.WriteLine(ob1.engine.HasFuell);


        }
    }
}
