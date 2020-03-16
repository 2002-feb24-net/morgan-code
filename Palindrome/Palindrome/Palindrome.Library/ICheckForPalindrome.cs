using System;

namespace Palindrome.Library
{
    public interface ICheckForPalindrome
    {
        bool _isPalindrome = false;
        public static bool CheckPalindrome(string forward)
        {
            char[] array = forward.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);

            if (forward == backwards)
            {
                return true;
            }
            return false;
        }
    }
}
