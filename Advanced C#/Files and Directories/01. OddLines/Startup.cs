using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            using (var fileReader = new StreamReader(
                @"C:\Users\Khaoz\Documents\visual studio 2015\Projects\SoftUni Exercises\Files and Directories\01. OddLines\input.txt"))
            {
                var line = fileReader.ReadLine();
                int lineCount = 0;
                using (var fileWriter = new StreamWriter(
                    @"C:\Users\Khaoz\Documents\visual studio 2015\Projects\SoftUni Exercises\Files and Directories\01. OddLines\output.txt", true))
                {
                    while (line != null)
                    {
                        if (lineCount % 2 != 0)
                        {
                            fileWriter.WriteLine(line);
                        }
                        line = fileReader.ReadLine();
                        lineCount += 1;
                    }
                }
            }
        }
    }
}
