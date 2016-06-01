using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TextFilter
{
    public class Startup
    {
        public static void Main()
        {
            var sb = new StringBuilder();

            string[] bannedWords = Console.ReadLine()
                .Split(new[] { ", ", " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string outputText = string.Empty;

            sb.Append(text);
            foreach (string bannedWord in bannedWords)
            {
                sb.Replace(bannedWord, new string('*', bannedWord.Length));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
