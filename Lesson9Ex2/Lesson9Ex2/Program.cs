using System;

namespace Lesson9Ex2
{
    class Program
    {
        static void Main(string[] args)
        {   
            String[] insertDateArray = new String[3]{
                  "Εισάγεται το έτος της αρχικής ημερομηνίας: ",
                  "Εισάγεται τον μήνα της αρχικής ημερομηνίας: ",
                  "Εισάγεται την ημέρα της αρχικής ημερομηνίας: "};

            DateTime currDateTime = DateTime.Now;
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding("windows-1253");
            Console.WriteLine("Η σημερινή ημερομηνία είναι: " + currDateTime + "\n");
            
            int[] inArray1 = new int[3];
            int[] inArray2 = new int[3];
            DateTime outDateTime1; 
            DateTime outDateTime2;
            TimeSpan newDateTime;

            for(int i=0; i<1; i++)
            {
                for (int j = 0; j < insertDateArray.Length; j++)
                {
                    Console.WriteLine(insertDateArray[j]);
                    inArray1[j] = Int32.Parse(Console.ReadLine());
                }
                outDateTime1 = new DateTime(inArray1[0], inArray1[1], inArray1[2]);
                Console.WriteLine(outDateTime1);

                for (int k = 0; k < insertDateArray.Length; k++)
                {
                    Console.WriteLine(insertDateArray[k]);
                    inArray2[k] = Int32.Parse(Console.ReadLine());
                }
                outDateTime2 = new DateTime(inArray2[0], inArray2[1], inArray2[2]);
                Console.WriteLine(outDateTime2);

                newDateTime = outDateTime2.Subtract(outDateTime1);
                Console.WriteLine($"\nΗ διαφορά σε ημέρες μεταξύ {outDateTime1} και {outDateTime2} ειναι: {newDateTime:dd}");
            }
        }
    }
}
