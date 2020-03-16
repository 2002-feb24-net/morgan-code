using System;
using Palindrome.Library;
using Xunit;

namespace Palindrome.App
{
    class Program
    {
        static void Main(string[] args)
        {

            InputOutput inputOutputSpecific = new InputOutput();
            IInputOutput inputOutputGeneral = inputOutputSpecific;
            var Palindrome = new Palindrome(inputOutputGeneral);

            Palindrome.CheckPalindrome(inputOutputGeneral);
        }
    }
}
