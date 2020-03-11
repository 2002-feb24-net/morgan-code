using System;
using System.Collections.Generic;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> bagOfStrings = new HashSet<string>();
            bagOfStrings.Add("Russell");
            bagOfStrings.Add("Mahir");
            bagOfStrings.Add("Paul");
            bagOfStrings.Add("Paul");

            System.Console.WriteLine(bagOfStrings.Count); // 3

            bool isPaulHere = bagOfStrings.Contains("Paul"); //true
            bagOfStrings.Remove("Paul");

            //basically the same as AddRange on List
            bagOfStrings.UnionWith(new string[] {"abc", "bca", "b"});

        }
    }
}
