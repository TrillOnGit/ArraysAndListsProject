using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] intArr = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            for (int i = 0; i < 10; i++)
            {
                intArr[i] = i + 1;
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            
            //Don't mind me, just testing.
            List<int> evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int number in intArr)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine(string.Join(", ", evens.ToArray()));

            Console.WriteLine(string.Join(", ", odds.ToArray()));
        }
    }
}
