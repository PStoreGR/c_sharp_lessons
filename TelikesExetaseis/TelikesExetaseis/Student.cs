using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelikesExetaseis
{
    class Student : Human //INHERITANCE 
    {
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            private set { _birthDate = value; }
        }

        public Student() // INHERITANCE AND OVERLOADS IT.
            :base()
        {
            BirthDate = _birthDate;
        }


        public int CalculateAge()
        {
            int years = DateTime.Now.Year - _birthDate.Year;
            if ((_birthDate.Month > DateTime.Now.Month) || (_birthDate.Month == DateTime.Now.Month))
            {
                years--;
            }
            return years;
        }

        public override string ToString()
        {
            string info = "Student : " + Firstname + " " + Lastname + "\n";
            info += "Student : " + CalculateAge() + " Years Old. \n";
            return info;
        }

        public override void InsertData()
        {
            base.InsertData();
            DateTime birthdate = new DateTime();
            Console.WriteLine("Please give Student's Birthdate in format : DD/MM/YYYY");
            string readDate = Console.ReadLine();
            while (!DateTime.TryParseExact(readDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthdate) || birthdate.CompareTo(DateTime.Now) > 0)
            {
                Console.WriteLine("You did not give a date or the date has not come yet!!");
                Console.Write("Give the Student's Date Of Birth: ");
                readDate = Console.ReadLine();
            }
            BirthDate = birthdate;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(Student stdnt)
        {
            if (stdnt == null) return false;
            return Firstname == stdnt.Firstname && Lastname == stdnt.Lastname && BirthDate == stdnt.BirthDate;
        }
    }
}
