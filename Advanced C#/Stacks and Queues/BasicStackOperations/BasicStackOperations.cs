using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    public class BasicStackOperations
    {
        public static void Main()
        {
            //commands:
            //first number = amount of elements to push into the stack
            // second number = amount of elements to pop from the stack
            //third number = element to check if is contained in the stack
            int[] commandNumbers =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int[] inputNumbers =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < commandNumbers[0]; i++)
            {
                numbers.Push(inputNumbers[i]);
            }

            for (int i = 0; i < commandNumbers[1]; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (numbers.Contains(commandNumbers[2]))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}