using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameToGradeMap = new Dictionary<string, int>();

            // indexing
            nameToGradeMap["Bob"] = 91;

            // instead of using a Dictionary, we could use a class to combine those 2 values and store a List of class instances

            foreach (var item in nameToGradeMap)
            {
                string key = item.Key;
                int value = item.Value;
            }
        }
    }
}
