using System;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter sw = new StreamWriter(@"test.txt"))
            {
                sw.WriteLine("Hello World");
            }

            using (StreamReader sr = File.OpenText("test.txt"))
            {
                string s = "";
                Console.WriteLine("This is the contents of the text file: ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine("{0}", s);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
