using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacter
{
    using System.Globalization;

    public class Startup
    {
        public static void Main()
        {
            var sb = new StringBuilder();

            char[] text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                sb.Append($"\\u00{(int)text[i]:x}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
