using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!charsCount.ContainsKey(text[i]))
                {
                    charsCount.Add(text[i], 0);
                }
                charsCount[text[i]]++;
            }

            foreach (var kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }
        }
    }
}
