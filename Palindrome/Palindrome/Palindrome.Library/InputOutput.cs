using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class InputOutput: IInputOutput
    {

        public string Input()
        {
            return Console.ReadLine().ToLower().Replace("[^a-zA-Z^0-9]", ""); ;
        }
        public void Output(string str)
        {
            Console.Write(str);
        }
    }
}
