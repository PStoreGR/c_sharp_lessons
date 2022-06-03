using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Ex1
{
    class Courses
    {
        public String title;
        private String[] CourseStreame = new string[2] {"Full", "Part"};

        public Courses()
        {

        }
        public String Title()
        {
            return title;
        }

        public String Streame()
        {
            foreach (var streame in CourseStreame)
            {
                Console.WriteLine(streame);
            }
        }

    }
}
