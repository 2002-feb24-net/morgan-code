using System;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            var John = new Person("John", 20);
            var Peter = new Person("Peter", 32);
            var Sam = new Person("Sam", 61);
            var Larry = new Person("Larry", 64);
            var Sara = new Person("Sara", 27);

            System.Console.WriteLine(John.ToString());
            System.Console.WriteLine(Peter.ToString());
            System.Console.WriteLine(Sam.ToString());
            System.Console.WriteLine(Larry.ToString());
            System.Console.WriteLine(Sara.ToString());

        }
    }
}


//the difference between bubble and merge sort:
//bubble: Bubble sort goes through the array one by one and swaps values to put the lower value on the left and larger value on the right.
//        It begins with indeces 0 and 1, moves to 1 and 2, 2 and 3, and so on. 
//        Once it reaches the end of the array, it will repeat the process until it makes a complete cycle without having to make any changes.
//
//merge: In the merge sort, we break the array down into 2 equal (or 1 off) subsets over and over until we have one value in each subset.
//       After this, we start comparing two subsets together and putting them in the "parent" subset.
//       We continue this, putting the lowest value between the subsets into larger subsets until we have built a fully sorted array back together.
//
// difference: bubble can only compare 2 indexes at a time while merge compares subsets together
//             In O(n) notation- bubble: O(n^2), merge: O(log n). This basically says that merge sort is more efficient in the long run.