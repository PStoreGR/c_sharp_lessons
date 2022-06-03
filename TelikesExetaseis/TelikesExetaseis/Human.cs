using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelikesExetaseis
{
    class Human
    {
        private string _firstname;
        private string _lastname;

        public String Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public String Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public Human()
        {
            Firstname = _firstname;
            Lastname = _lastname;
        }

        public virtual void InsertData()
        {
            Console.WriteLine("Give First Name : ");
            string name = Console.ReadLine();
            Firstname = name;
            Console.WriteLine("Give Last Name : ");
            string lastname = Console.ReadLine();
            Lastname = lastname;
        }
    }
}
