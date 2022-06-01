using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Architect architect = new Architect();
            architect.setSalary(10000);
            architect.setBonus(2000);
            Console.WriteLine("Salary: " + architect.getSalary());
            Console.WriteLine("Bonus: " + architect.getBonus());
            Console.WriteLine("Total: " + architect.SetTotalSalary());

        }
    }
}
