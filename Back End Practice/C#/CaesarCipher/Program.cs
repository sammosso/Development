using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message to be encoded:");
            string inputToEncode = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter key:");
            int userKey = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("This is your encrypted message:");
            string encodedCipher = Encode(inputToEncode, userKey);
            Console.WriteLine(encodedCipher);
            Console.WriteLine();

            Console.WriteLine("Copy and paste the message you would like to decyrpt:");
            string inputToDecode = Console.ReadLine();
            Console.WriteLine();
            string decodedCipher = Decode(inputToDecode, userKey);
            Console.WriteLine(decodedCipher);

            Console.Read();
        }
        public static string Encode(string input, int key)
        {
            if (input == null) return null;

            // Ensure shift is between 0 and 25
            key %= 26;

            var result = string.Empty;
            var wrapValue = ('~' - '!') + 1;

            // Loop through input and update result with shifted letters
            foreach (var character in input)
            {
                if ((character >= '!') && (character <= '~'))
                {
                    var newChar = (char)(character - key);
                    // Wrap around to the end
                    if (newChar < '!')
                    {
                        newChar += (char)wrapValue;
                    }
                    result += newChar;
                }
                else
                {
                    // Add anything besides above to my results
                    result += character;
                }
            }
            return result;
        }
        public static string Decode(string input, int key)
        {
            if (input == null) return null;

            // Ensure shift is between 0 and 25
            key %= 26;

            var result = string.Empty;
            var wrapValue = ('~' - '!') + 1;

            // Loop through input and update result with shifted letters
            foreach (var character in input)
            {
                if ((character >= '!') && (character <= '~'))
                {
                    var newChar = (char)(character + key);
                    // Wrap around to the end
                    if (newChar > '~')
                    {
                        newChar -= (char)wrapValue;
                    }
                    result += newChar;
                }
                else
                {
                    // Add anything besides above to my results
                    result += character;
                }
            }
            return result;
        }
    }
}
