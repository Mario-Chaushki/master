using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CharacterMultiplier
{
    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
            string str1 = input[0];
            string str2 = input[1];

            int sum = 0;
            if (str1.Length <= str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += char.Parse(str1.Substring(i, 1)) * char.Parse(str2.Substring(i, 1));
                }
                for (int i = 0; i < str2.Length - str1.Length; i++)
                {
                    sum += char.Parse(str2.Substring(str2.Length - str1.Length, 1));
                }
            }
            else
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum += char.Parse(str1.Substring(i, 1)) * char.Parse(str2.Substring(i, 1));
                }
                for (int i = 0; i < str1.Length - str2.Length; i++)
                {
                    sum += char.Parse(str1.Substring(str1.Length - str2.Length, 1));
                }
            }

            Console.WriteLine(sum);
        }
    }
}
