using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                bool isPalindrome = Palindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }

        /// <summary>
        /// Checks if a string is a palindrome. Throws an exception if the
        /// string is null. Uses a local method to help with the logic.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static bool Palindrome(string input)
        {
            bool IsPalindrome(string input1)
            {
                return input1.SequenceEqual(input1.Reverse());
            }

            bool result;

            if (input == null)
            {
                throw new ArgumentNullException("String can't be null");
            }

            if (input.Length < 2)
            {
                result = false;
            }
            else
            {
                result = IsPalindrome(input);
            }

            return result;
        }
    }
}
