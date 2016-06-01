using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateSequenceWithAQueue
{
    public class CalcSequenceWithQueue
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            result.Add(n);
            Queue<int> elementsInSequence = new Queue<int>();
            elementsInSequence.Enqueue(n);
            while (result.Count < 50)
            {
                int currentElement = elementsInSequence.Dequeue();
                int firstNumber = currentElement + 1;
                int secondNumber = (currentElement * 2) + 1;
                int thirdNumber = currentElement + 2;

                elementsInSequence.Enqueue(firstNumber);
                elementsInSequence.Enqueue(secondNumber);
                elementsInSequence.Enqueue(thirdNumber);

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
