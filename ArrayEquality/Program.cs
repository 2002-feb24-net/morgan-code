using System;

namespace ArrayEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {1, 2, 3};
            int[] array2 = {1, 2, 3, 4};
            int[] array3 = {1, 2, 3, 4};
            int[] array4 = {0, 2, 3};

            if (ArraysEqual(array1, array2))
            {
                System.Console.WriteLine("1 & 2");
            }
            if (ArraysEqual(array2, array3))
            {
                System.Console.WriteLine("2 & 3");
            }
            if (ArraysEqual(array3, array4))
            {
                System.Console.WriteLine("3 & 4");
            }
        }

        static bool ArraysEqual(int[] arrayA, int[] arrayB)
        {
            bool equal = false;

            // 1. it could only be equal if the lengths are equal
            if(arrayA.Length == arrayB.Length)
            {
                // ...logic...
                for (int i = 0; i < arrayA.Length; i++)
                {
                    // for each index...
                    if(arrayA[i] != arrayB[i])
                    {
                        equal = false;
                    }
                }
            }
            else
            {
                equal = true;
            }

            if (equal)
            {
                Console.WriteLine("These arrays are equal");
            }
            else
            {
                Console.WriteLine("These arrays are not equal");
            }
        }
    }
}
