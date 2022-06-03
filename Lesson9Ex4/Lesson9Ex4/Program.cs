using System;
using System.Globalization;
using System.Threading;

namespace Lesson9Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding("windows-1253");
            // = new CultureInfo("el-GR");
            var cultures = new CultureInfo[5]
                           {new CultureInfo("fr-LU"),
                            new CultureInfo("en-EN"),
                            new CultureInfo("fr-FR"),
                            new CultureInfo("en-US"),
                            new CultureInfo("el-GR")};

            String[] outArray = new string[5] 
                                {"Σε Γαλλικά (Αφρικής)",
                                 "Σε Αγγλικά (Αγγλίας)",
                                 "Σε Γαλλικά (Αμερικής)",
                                 "Σε Αγγλικά (Αμερικής)",
                                 "Σε Ελληνικά (Ελλάδας)"};

            for (int i=0; i<outArray.Length; i++)
            {
                Console.WriteLine(outArray[i] + "   " + cultures[i].Name +
                            " " + cultures[i].ToString());
            }
        }
    }
}
