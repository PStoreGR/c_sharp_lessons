using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelikesExetaseis
{
    class Program
    {
        static void Main(string[] args)
        {
            School sc = new School();
            string input = "n";
            
            do
            {
                Console.Clear();
                sc.Menu();
                Console.WriteLine("Want to Exit From School?? [y/n]");
                input = Console.ReadLine();
            } while (input != "y");

            if (input == "y")
            {
                Console.WriteLine("Exit....");
                System.Environment.Exit(0);
            }
        }
    }
}
