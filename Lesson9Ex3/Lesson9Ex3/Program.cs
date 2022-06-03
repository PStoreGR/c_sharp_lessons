using System;

namespace Lesson9Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inDate;
            bool run = true;

            while (run)
            {
                Console.WriteLine("Παρακαλώ δώστε την επιθυμητή ημερομηνία σε μορφή: 'εεεε/μμ/ηη'");
                inDate = Console.ReadLine();
                DateTime outDate, nextmonth; 
                var isvalidInDate = DateTime.TryParse(inDate, out outDate);

                if (isvalidInDate)
                {
                    Console.WriteLine(outDate);
                    Console.WriteLine($"Δώσατε την ημερομηνία : {outDate}");
                    nextmonth = outDate.AddMonths(1);

                    Console.WriteLine($"Το όνομα της μέρας του επόμενου μήνα είναι : {nextmonth.DayOfWeek}");
                    run = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{inDate} μη αποδεκτή. Παρακαλώ ξαναδοκιμάστε!");
                    run = true;
                    continue;
                }
            }            
        }
    }
}
