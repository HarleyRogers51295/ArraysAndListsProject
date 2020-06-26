using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // DONE: Create an int Array and populate numbers 1-10
            int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* DONE: Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* DONE: Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List 
             */
            for (int i = 0; i < 20; i++)
            {
                int num = i;
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else if (num % 2 != 0)
                {
                    odds.Add(num);
                }

            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach(int num in evens)
            {
                Console.Write("Here is an even number from list evens:");
                Console.WriteLine(num);
            }
            foreach(int num in odds)
            {
                Console.Write("Here is an odd number from the list odds:");
                Console.WriteLine(num);
            }
        }

    }
}
