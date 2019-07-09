using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.b
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new InputNames();
            a.Run();
        }
    }

    class InputNames
    {
        public void Run()
        {
            // how can I import a text file into a QUEUE data structure?
            // 1. get a HANDLE on the text file.

            // Read file using StreamReader. Reads file line by line  

            // string textFileName = "C:\Users\HP\Dropbox\Academic_Desk\ProgramCode\CSharpDataStructure\ConsoleApp1\ConsoleApp1";
            var fileStream = new FileStream(@"U:\Users\735619\9July2019\assignment3.b\names.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader file = new StreamReader(fileStream))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }
}