using System;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user to enter a string
            System.Console.WriteLine("Enter a string to be abbreviated: ");
            //reading the user input, spliting their phrase up by a space, and putting each word in an array
            string wholePhrase = System.Console.ReadLine();
            //using the CreateAcronym() method, we are returning the string that is created in the method
            string output = CreateAcronym(wholePhrase);
            //writes the output to the program
            System.Console.WriteLine(output);
        }

        static string CreateAcronym(string str)
        {
            //the input we need to run this method is "string[] str"
            string[] words = str.Split(' ');
            //firstLetter is going to be what is returned to output. We are starting with it empty and can fill it in after we determine the acronym
            string firstLetter = "";

            //going to cycle through each index of the array 
            for (int i = 0; i <= words.Length - 1; i++)
            {
                //cycling through each index of the array taking the first letter(index 0) and using a length of 1
                firstLetter += words[i].Substring(0, 1).ToUpper();
            }

            return firstLetter;
        }
    }
}
