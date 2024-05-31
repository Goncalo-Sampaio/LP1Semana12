using System;
using System.Linq;

namespace Palindrome
{
    /// <summary>
    /// Main class for this project
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method of the program which will iterate through the arguments
        /// to check if they are palindromes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Iterates through each arg
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
            //Local method that handles the logic to check if its palindrome
            bool IsPalindrome(string input1)
            {
                return input1.SequenceEqual(input1.Reverse());
            }

            bool result;

            //throws an exception if the string is null
            if (input == null)
            {
                throw new ArgumentNullException("String can't be null");
            }

            //true if the string length is less than 2
            if (input.Length < 2)
            {
                result = true;
            }
            else
            {
                result = IsPalindrome(input);
            }

            return result;
        }
    }
}
