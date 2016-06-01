using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FormattingNumbers
{
    public class Startup
    {
        public static void Main()
        {
            //Reads 3 numbers separated by space
            string[] numbers = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

            int a = int.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);

            Console.Write("|");
            Console.Write($"{a:X}");
            for (int i = 0; i < 10 - a.ToString().Length; i++)
            {
                Console.Write(" ");
            }

            Console.Write($"|00{Convert.ToString(a, 2)}|");

            for (int i = 0; i < 10 - b.ToString().Length; i++)
            {
                Console.Write(' ');
            }
            Console.Write($"{b:F2}|");

            Console.Write($"{c:F3}");
            for (int i = 0; i < 10 - c.ToString().Length; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|" + Environment.NewLine);
        }
    }
}
