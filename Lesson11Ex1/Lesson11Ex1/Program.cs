using System;

namespace Lesson11Ex1
{
    class Program
    {
        public class Customer
        {
            public int id;
            public string name;

            public Customer(int setid, string setname)
            {
                this.id = setid;
                this.name = setname;
            }

            public void Info()
            {
                Console.WriteLine($"Customer with id {this.id} is called {this.name}");
            }
        }
        static void Main(string[] args)
        {
            Customer cust1 = new Customer(100, "Smith");
            Customer cust2 = new Customer(200, "Sanders");

            cust1.Info();
            cust2.Info();
        }
    }
}
