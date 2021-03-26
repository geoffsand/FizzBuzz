using System;
using System.Diagnostics.Tracing;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100; counter = counter + 1)
            {

            if (counter % 3 != 0 && counter % 5 != 0)
                {
                    Console.WriteLine(counter);
                }
            else if (counter % 15 == 0)
                {
                Console.WriteLine("FizzBuzz");
                }
            else if (counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            else if (counter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
        }
    }
}

