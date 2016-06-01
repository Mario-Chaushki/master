using System;
using System.Collections.Generic;

namespace Basic_Stack_Operations
{
    using System.Collections;
    using System.Linq;

    public class ReverseNumbers
    {
        public static void Main()
        {
            int[] input =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Stack<int> numbers = new Stack<int>();

            foreach (int number in input)
            {
                numbers.Push(number);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
