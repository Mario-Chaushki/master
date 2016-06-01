using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            using (var fileReader = new StreamReader(
                @"C:\Users\Khaoz\Documents\visual studio 2015\Projects\SoftUni Exercises\Files and Directories\02. LineNumbers\input.txt"))
            {
                var line = fileReader.ReadLine();
                int lineCount = 1;
                using (var fileWriter = new StreamWriter(
                    @"C:\Users\Khaoz\Documents\visual studio 2015\Projects\SoftUni Exercises\Files and Directories\02. LineNumbers\output.txt", false))
                {
                    while (line != null)
                    {
                        fileWriter.WriteLine(lineCount + " " + line);
                        line = fileReader.ReadLine();
                        lineCount += 1;
                    }
                }
            }
        }
    }
}
