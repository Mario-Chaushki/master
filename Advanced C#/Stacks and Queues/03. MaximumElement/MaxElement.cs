using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximumElement
{
    public class MaxElement
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int numberOfQueries = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 0; i < numberOfQueries; i++)
            {   
                int[] query =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (query[0] == 1)
                {
                    if (query[1] > maxNumber)
                    {
                        maxNumber = query[1];
                        maxNumbers.Push(maxNumber);
                    }
                    numbers.Push(query[1]);
                } else if (query[0] == 2)
                {
                    if (query[0] == 1)
                    {
                        if (numbers.Peek() == maxNumber)
                        {
                            maxNumbers.Pop();
                        }
                        numbers.Pop();
                    } else if (query[0] == 3)
                {
                    maxNumbers.Push(numbers.Max());
                }
            }
            
            foreach (int outputNumber in maxNumbers)
            {
                Console.WriteLine(outputNumber);
            }
        }
    }
}
