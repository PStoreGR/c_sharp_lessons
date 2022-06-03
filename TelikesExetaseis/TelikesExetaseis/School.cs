using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelikesExetaseis
{
    class School
    {
        private List<Subject> _subjects; // AGGREGATION RELATION
        private List<Student> _students; // AGGREGATION RELATION

        public School()
        {
            _subjects = new List<Subject>(); 
            _students = new List<Student>(); 
        }
        public void Menu()
        {
            List<string> menu = new List<string>{"Select From The List Menu.",
                                                 "1 to insert a student.",
                                                 "2 to insert a subject.",
                                                 "3 to see all students.",
                                                 "4 to see all subjects.",
                                                 "5 to see all student per subject.",
                                                 "press any key to exit."};

            foreach (string line in menu)
            {
                Console.WriteLine(line);
            }

            string choice1 = Console.ReadLine();
            string choice2;
            
            switch (choice1)
            {
                case "1":
                    {
                        do
                        {
                            AddStudents();
                            Console.WriteLine("Do you want to add another student? [y/n] ");
                            choice2 = Console.ReadLine();
                        } while (choice2 == "y");
                        break;
                    }
                case "2":
                    {
                        do
                        {
                            AddNewSubject();
                            Console.WriteLine("Do you want to add another subject? [y/n] ");
                            choice2 = Console.ReadLine();
                        } while (choice2 == "y");
                        break;
                    }
                case "3":
                    {
                        do
                        {
                            ShowStudents();
                            break;
                        } while (_students.Count > 0);
                        break;
                    }
                case "4":
                    {
                        do
                        {
                            ShowSubjects();
                            break;
                        } while (_subjects.Count > 0);
                        break;
                    }
                case "5":
                    {
                        do
                        {
                            ShowStudentPerSubject();
                            break;

                        } while (_students.Count > 0 && _subjects.Count > 0);
                        break;
                    }
                default:
                    {
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    }
            }
        }

        public void AddStudents()
        {
            Student stdnt = new Student(); // ASSOCIATION RELATION
            stdnt.InsertData();
            
            if (!_students.Contains(stdnt))
            {
                _students.Add(stdnt);
                AddStudentInSubjects(stdnt);
                Console.WriteLine("You Added a New Student to Subject List\n");
            }
            else Console.WriteLine("Student Already Exists!");
        }

        public void AddNewSubject()
        {
            Subject subj = new Subject(); // ASSOCIATION RELATION
            subj.InsertData();
            if (!_subjects.Contains(subj))
            {
                _subjects.Add(subj);
                Console.WriteLine("\nYou have Added a new Subject to Subjects List");
            }
            else Console.WriteLine("Subject Already Exists!");            
        }

        public void AddStudentInSubjects(Student stdnt)
        {
            if (_students.Count > 0)
            {
                Console.WriteLine("Want to add a student to a subject? [y/n] ");
                string choice = Console.ReadLine();
                if(choice == "y")
                {
                    Console.WriteLine("\nSubjects : " + _subjects.Count);
                    for (int i = 0; i < _subjects.Count; i++)
                    {
                        Console.WriteLine($"\nSubject {i}");
                        Console.WriteLine($"\n{_subjects[i]}");
                    }
                    do
                    {
                        Console.WriteLine("\nSelect Subject: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        if (pos >= 0 && pos < _subjects.Count)
                        {
                            _subjects[pos].AddStudents(stdnt);
                            break;
                        }
                        else if (pos >= 0 && pos >= _subjects.Count)
                        {
                            break;
                        }

                    } while (_subjects.Count > 0);
                }                
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine("\nStudents : " + _students.Count);
            for (int i=0; i<_students.Count; i++)
            {
                Console.WriteLine(_students[i]);
            }
        }

        public void ShowSubjects()
        {
            Console.WriteLine("\nSubjects : " + _subjects.Count);
            for (int i = 0; i < _subjects.Count; i++)
            {
                Console.WriteLine(_subjects[i]);
            }
        }

        public void ShowStudentPerSubject()
        {
            Console.WriteLine("\nSubjects : " + _subjects.Count);
            for (int i = 0; i < _subjects.Count; i++)
            {
                Console.WriteLine($"\nSubject {i}");
                Console.WriteLine($"\n{_subjects[i]}");
            }
            do
            {
                Console.WriteLine("\nSelect Subject: ");
                int pos = Convert.ToInt32(Console.ReadLine());
                if (pos >= 0 && pos < _subjects.Count)
                {
                    _subjects[pos].ListOfStudents();
                    break;
                }
                else if (pos >= 0 && pos >= _subjects.Count)
                {
                    break;
                }

            } while (_subjects.Count > 0);
        }
    }
}
