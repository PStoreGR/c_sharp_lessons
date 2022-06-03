using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Ex1
{
    class Student
    {
        public List<Courses> course { get; set; } = new List<Courses>();
        public String FirstName { get; set; }
        public String LastName { get; set; }
        private double fees;

        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

    }
}
