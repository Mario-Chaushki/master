using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstingOccurances
{
    public class Startup
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < text.Length - word.Length; i++)
            {
                if (text.Substring(i, word.Length).Equals(word, StringComparison.CurrentCultureIgnoreCase))
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
