using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumBigNumbers
{
    public class Startup
    {
        public static void Main()
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
