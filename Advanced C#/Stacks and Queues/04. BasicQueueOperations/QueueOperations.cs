using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    public class QueueOperations
    {
        public static void Main()
        {
            //read from line n1 = numbers to enqueue, n2 = numbers to dequeue, n3 = number to check if present
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

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < commandNumbers[0]; i++)
            {
                numbers.Enqueue(inputNumbers[i]);
            }

            for (int i = 0; i < commandNumbers[1]; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Count == 0)
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
