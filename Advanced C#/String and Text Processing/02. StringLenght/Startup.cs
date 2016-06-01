using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLenght
{
    public class Startup
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            if (input.Length >= 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(input[i]);
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(input[i]);
                }
                for (int i = 0; i < 20 - input.Length; i++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
