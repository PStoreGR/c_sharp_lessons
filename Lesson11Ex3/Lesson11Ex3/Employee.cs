using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Ex3
{
    class Employee
    {
        public string name;
        private int age = 0;

        public Employee(String Name)
        {
            name = Name;
            Console.WriteLine($"Η αρχική ηλικία του {Name} είναι: {age}");
            Console.WriteLine($"Δώστε την ηλικία του {Name}: ");
            getInfo = Int32.Parse(Console.ReadLine());
            if (checkAge(getInfo) > 0)
            {
                Console.WriteLine($"Η ηλικία του {Name} έγινε: {getInfo}");
            }
            else if (checkAge(getInfo) == 0)
            {
                getInfo = 0;
                Console.WriteLine("Μη έγκυρη ηλικία!!");
                Console.WriteLine($"Η ηλικία του {Name} έγινε: {age}");
            }
        }

        public int getInfo
        {
            get { return age; }
            set { age = value; }
        }

        private int checkAge(int Age)
        {
            Age = getInfo;
            if (Age < 0)
            {
                return 0;
            }
            else if (Age > 80)
            {
                return 0;
            }
            else if (Age == 0)
            {
                return 0;
            }
            else
            {
                return Age;
            }
        }

    }

}
