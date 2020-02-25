using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] inputArray = {8, 3, 9, 11, 2};

            Console.WriteLine($"Add numbers with one space between each:");
            //get user input
            string inputValues = Console.ReadLine();
            string[] inputStringArray = inputValues.Split(' ');
            int[] inputArray = Array.ConvertAll(inputStringArray, int.Parse);
            Console.WriteLine();

            Console.Write($"My original array: ");
            printArray(inputArray);
            Console.WriteLine();
            BubbleSort(inputArray);
            ReverseBubbleSort(inputArray);
        }
        static void BubbleSort(int[] inArr)
        {
            int temp = 0;
            for (int i = 1; i <= (inArr.Length - 1); i++)
            {
                for (int j = 0; j < (inArr.Length -1); j++)
                {
                    if (inArr[j + 1] < inArr[j])
                    {
                        temp = inArr[j];
                        inArr[j] = inArr[j + 1];
                        inArr[j + 1] = temp;
                    }
                }
            }
            Console.Write($"My sorted array: ");
            printArray(inArr);
            Console.WriteLine();
        }
        static void ReverseBubbleSort(int[] inArr)
        {
            int temp = 0;
            for (int i = 1; i <= (inArr.Length - 1); i++)
            {
                for (int j = 0; j < (inArr.Length - 1); j++)
                {
                    if (inArr[j + 1] > inArr[j])
                    {
                        temp = inArr[j];
                        inArr[j] = inArr[j + 1];
                        inArr[j + 1] = temp;
                    }
                }
            }
            Console.Write($"My sorted array in reverse: ");
            printArray(inArr);
            Console.WriteLine();
        }
        static void printArray(int[] myArray)
        {
            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
