using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelikesExetaseis
{
    enum LangValues { CSharp, Java, Python }
    enum TypeValues { FullTime, PartTime }

    class Subject
    {
        private string _id;
        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private LangValues _lang;
        public LangValues Lang
        {
            get { return _lang; }
            set { _lang = value;}
        }

        private TypeValues _type;
        public TypeValues Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        private List<Student> _students; // AGGREGATION RELATION

        public Subject()
        {
            Id = _id;
            Lang = _lang;
            Type = _type;
            StartDate = _startDate;
            EndDate = _endDate;
            _students = new List<Student>();
        }

        public void InsertData()
        {
            Console.WriteLine("Give the Subjects id : CSharp Java Python");
            string choice = Console.ReadLine();
            Id = choice;

            Console.WriteLine("Select the subjects language. 1 for CSharp 2 for Java 3 for Python. : ");
            LangValues language = (LangValues)Convert.ToInt32(Console.ReadLine());
            Lang = language;
            Lang--;
            
            Console.WriteLine("Select the subjects type. 1 For Full Time, 2 For Part Time. : ");
            TypeValues typeval = (TypeValues)Convert.ToInt32(Console.ReadLine());
            Type = typeval;
            Type--;

            DateTime date;
            Console.WriteLine("Give the Start Date of Subject in format DD/MM/YYYY : ");
            choice = Console.ReadLine();
            while (!DateTime.TryParseExact(choice, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date) || date.CompareTo(DateTime.Now) > 0)
            {
                Console.WriteLine("You did not give a correct date!!");
                Console.WriteLine("Give the Start Date of Subject in format DD/MM/YYYY : ");
                choice = Console.ReadLine();
            }
            StartDate = date;

            Console.WriteLine("Give the End Date of Subject in format DD/MM/YYYY : ");
            choice = Console.ReadLine();
            while (!DateTime.TryParseExact(choice, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date) || date.CompareTo(DateTime.Now) > 0)
            {
                Console.WriteLine("You did not give a correct date!!");
                Console.WriteLine("Give the Start Date of Subject in format DD/MM/YYYY : ");
                choice = Console.ReadLine();
            }
            EndDate = date;
        }

        public override string ToString()
        {
            string info = "Subject : " + Id + " of " + Lang + "\n" + "Subject Type : " + Type + "\n";
            info += "Subject Starts : " + StartDate.ToString("dd'/'MM'/'yyyy HH:mm:ss") + "\n" +
                "Subject Ends : " + EndDate.ToString("dd'/'MM'/'yyyy HH:mm:ss") + "\n";
            return info;
        }

        public void ListOfStudents()
        {
            foreach(var stdnt in _students)
            {
                Console.WriteLine(stdnt);
            }
        }

        public void AddStudents(Student stdnt) 
        {
            _students.Add(stdnt);
        }

        public bool Equals(Subject sub) 
        {
            if (sub == null) return false;
            return Id == sub.Id && Lang == sub.Lang && Type == sub.Type
                    && StartDate == sub.StartDate && EndDate == sub.EndDate;
        } 
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
