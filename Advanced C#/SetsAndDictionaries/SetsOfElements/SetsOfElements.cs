using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            int[] input =
                Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int firstSetLength = input[0];
            HashSet<int> firstSet = new HashSet<int>();
            int secondSetLength = input[1];
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < secondSetLength; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
            firstSet.UnionWith(secondSet);

            foreach (var number in firstSet)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\r");
        }
    }
}
