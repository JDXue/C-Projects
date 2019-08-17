using System;

namespace ConsoleApp3
{
    class Rle
    {

        public string Compression(string input)
        {
            int i = 1;
            int repeat = 0;
            string comp = input[0].ToString();
            Console.WriteLine("{0} characters long", input.Length);
            for (i = 1; i != input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    repeat++;
                }
                else
                {   if (input.Length > 1)
                    {
                        comp += input[i - 1];
                        comp += repeat;
                        Console.WriteLine(comp);
                        comp += input[i];
                        Console.WriteLine(comp);
                        repeat = 0;
                    }
                }
            }
            Console.WriteLine("Compressed: {0}",comp);
            return comp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Boolean accept = false;
            while (accept == false)
            {
                try
                {
                    string e;
                    Console.WriteLine("Enter your string input here:");
                    input = Console.ReadLine();
                    accept = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Please try again, make sure to enter a value", e);

                }
 

            }
            Rle c;
            c = new Rle();
            c.Compression(input);
            Console.ReadLine();
        }
    }
}
