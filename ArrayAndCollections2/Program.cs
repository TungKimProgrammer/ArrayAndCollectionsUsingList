// # nullable disable
using System;
using System.Reflection;
using System.Collections.Generic;

namespace ArraysAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> originalNums = GetNumbers();
            DisplayArray(originalNums);
        }

        /// <summary>
        /// get user input 
        /// </summary>
        /// <returns>an array of numbers entered</returns>
        private static List<int> GetNumbers()
        {
            Console.WriteLine("Please enter a number (up to total 10 numbers). Enter 0 to stop!");

            int index = 0;

            List<int> list = new();
            do
            {
                Console.Write("Number " + (index + 1) + ": ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (result == 0)
                    {
                        break;
                    }
                    else
                    {
                        list.Add(result);
                        index++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer!");
                }
            } while (true);

            return list;
        }

        /// <summary>
        /// returns an array of doubled numbers from given array
        /// </summary>
        /// <param name="originalNums">original array</param>
        /// <returns>array with doubled values</returns>
        private static List<int> DoubleNumbers(List<int> originalNums)
        {
            List<int> doubledNumbers = new();

            foreach (int num in originalNums)
            { 
                doubledNumbers.Add(num * 2);
            }

            return doubledNumbers;
        }

        /// <summary>
        /// display the original array and the copy array with the doubled values afterwards 
        /// </summary>
        /// <param name="numbersArray"></param>
        private static void DisplayArray(List<int> numbersArray)
        {
            
            if (numbersArray.Count == 0)
            {
                Console.WriteLine("You did not enter any number!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The numbers entered: ");
                Console.WriteLine("[{0}]", string.Join(", ", numbersArray));
                //PrintArray(numbersArray);
                List<int> doubledNums = DoubleNumbers(numbersArray);
                Console.WriteLine();
                Console.WriteLine("The numbers entered are now doubled as: ");
                Console.WriteLine("[{0}]", string.Join(", ", doubledNums));
                //PrintArray(doubledNums);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// print an array with [] and commas
        /// or use Console.WriteLine("[{0}]", string.Join(", ", array));
        /// </summary>
        /// <param name="array">array needs to print</param>
        private static void PrintArray(List<int> array)
        {
            Console.WriteLine();

            Console.Write("[");

            for (int i = 0; i < array.Count - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.Write(array[^1]);
            Console.WriteLine("]");
        }
    }
}