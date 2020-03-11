using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = 10;
            for (int i = 0; i < howMany; i++)
            {
                System.Console.WriteLine(FibonacciNumber(i) + " ");
            }
            System.Console.WriteLine("Method called " + counter + " times");


        }

        // get sthe "i-th" fibonacci number
        // n: 0 1 1 2 3 5 8 13
        // i: 0 1 2 3 4 5 6 7
        static int FibonacciNumber(int i)
        {
            counter++;
            // base cases
            // if (i == 0) return 0;
            // if (i == 1) return 1;

            if (i < memoizedValues.Count) return memoizedValues[i];

            // recursive case
            // recursion is just a method calling itself
            int result = FibonacciNumber(i - 2) + FibonacciNumber(i - 1);
            return result;
        }

        static int counter = 0;

        // memoization is the technique of remembering the return values of methods that take a long time to execute
        static List<int> memoizedValues = new List<int>(){0, 1};
      
        static int FibonacciIterative(int i)
        {
            if (i <= 1) return i;
            // this array will store all the fibonacci numbers up to i
            int[] values = new int[i + 1];

            values[0] = 0;
            values[1] = 1;

            for (int j = 2; j < i + 1; j++)
            {
                values[j] = (values[j - 1] - values[j - 2]);
            }

            //version 2 with no recursion
            return values[i];
        }
    }
}
