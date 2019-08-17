using System;

namespace ConsoleApp2 { }

class Fibonacci
{
    int last;
    int steps;
    int term = 0;
    public int fib(int n)
    {
        last = 1;
        steps += n;
        if (steps != n)
        {
            term += last;
            Console.WriteLine("F( " + steps + ") = " + term);
        }
        return term;
    }
 }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci ex = new Fibonacci();
            int t;
            t = ex.fib(5);

        }
    }

