using System;

namespace Practice
{
    class isUnique
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string checkString = Console.ReadLine();
            checkUnique(checkString);
            Console.ReadLine();
        }
        private static void checkUnique(string s)
        {
            // loop through each character in string s.
            for (int i = 1; i < s.Length; i++)
            {
                //check the second character against the previous character.
                if (s[i - 1] == s[i])
                {
                    Console.WriteLine("String contains duplicate letters.");
                    break;
                }
                // checks if the value of the index gets to the end.
                else if (i == s.Length-1)
                {
                    Console.WriteLine("Every letter in this string is unique!");
                }
            }
        }
    }
}
