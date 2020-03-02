using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            CountFizzBuzz();
            //Fizz appears 267 times
            //Buzz appears 134 times
            //FizzBuzz appears 67 times
        }

        static void CountFizzBuzz()
        {
            int Fizz = 0;
            int Buzz = 0;
            int FizzBuzz = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if(i % 3 == 0 && i % 5 == 0){
                    System.Console.WriteLine("FizzBuzz");
                    FizzBuzz++;
                }
                else if(i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    Fizz++;
                }
                else if(i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    Buzz++;
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("Fizz appeared " + Fizz + " times!");
            System.Console.WriteLine("Buzz appeared " + Buzz + " times!");
            System.Console.WriteLine("Fizz Buzz appeared " + FizzBuzz + " times!");
        }
    }
}
