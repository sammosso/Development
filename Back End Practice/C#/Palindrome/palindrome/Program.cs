using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some characters:");
            string palindrome = Console.ReadLine();
            checkPalidrome(palindrome);

            if (checkPalidrome(palindrome))
            {
                Console.WriteLine("Yes! This is a Palidrome");
            }
            else
            {
                Console.WriteLine("No palindrome, try again!");
            }
            Console.WriteLine();

        }

        public static bool checkPalidrome(string palindrome)
        {
            char[] charArray = palindrome.ToCharArray();
            Array.Reverse(charArray);
            string newPalindrome = new string(charArray);

            if (newPalindrome == palindrome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
