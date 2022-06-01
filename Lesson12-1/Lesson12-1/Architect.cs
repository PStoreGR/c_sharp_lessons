using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1
{
    class Architect : Employee
    {
        public void setSalary(double Salary)
        {
            salary = Salary;
        }
        public void setBonus(float Bonus)
        {
            bonus = Bonus;
        }
        public double SetTotalSalary()
        {
            return salary + bonus;
        }
        public double getSalary()
        {
            return salary;
        }
        public double getBonus()
        {
            return bonus;
        }
    }
}
