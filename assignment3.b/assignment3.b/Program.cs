using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.b
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // var a = new InputNames();
            //a.Run();
            //new PlayWithStacks().Run();
            var z = new Grapefruit();
            z.Run();
        }
    }
    class Blueberry
    {
       
        public string StudentName;
        public string StudentNumber;
        public Blueberry Link;
    }
    class Grapefruit
    {
        //Grape fruit is the office Manager!
        Blueberry Head;
        Blueberry Node;
        public void Run()
        {
            Head = new Blueberry();

            Node = new Blueberry();
            Node.StudentName = "joe";
            Node.StudentNumber = "A101";
            Head.Link = Node;
            
        }
    }

    class InputNames
    {
        private static Queue<string> names;
        int counter = 0;

        public static Queue<string> GetQueue()
        {
            return names;
        }

        public void Run()
        {
            names = new Queue<string>();
            // how can I import a text file into a QUEUE data structure?
            // 1. get a HANDLE on the text file.

            // Read file using StreamReader. Reads file line by line  

            // string textFileName = "C:\Users\HP\Dropbox\Academic_Desk\ProgramCode\CSharpDataStructure\ConsoleApp1\ConsoleApp1";
            var fileStream = new FileStream(@"U:\Users\735619\9July2019\assignment3.b\names.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader file = new StreamReader(fileStream))
            {

                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    names.Enqueue(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }

    class PlayWithStacks
    {

        static Stack<string> names;

        public void Run()
        {
            // how do I access the names in the names Queue?
            // how to GET ACCESS TO THE NAMES QUEUE??

            names = new Stack<string>();
            //whenever we work with Collections, we use foreach =
            // Meaning: foreach element in the collection
            foreach (var item in InputNames.GetQueue())
            {
                names.Push(item);
            }
           names.Push((InputNames.GetQueue()).Dequeue());
        }
    }
}