using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            HashSet<string> usernames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            foreach (string username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
