using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WordCount
{
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<string, int> outputDict = new Dictionary<string, int>();

            string[] splitChars = new string[] { " ", ", ", "?", "!", "." };

            string inputPath =
            @"C:\Users\Khaoz\Documents\visual studio 2015\Projects\SoftUni Exercises\Files and Directories\03. WordCount\words.txt";

            string wordsPath =
                @"C:\Users\Khaoz\Documents\visual studio 2015\Projects\SoftUni Exercises\Files and Directories\03. WordCount\words.txt";


            using (var wordsReader = new StreamReader(wordsPath))
            {
                string[] words = wordsReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                outputDict.Add(words[0], 0);
                outputDict.Add(words[1], 0);
                outputDict.Add(words[2], 0);

                using (var fileReader = new StreamReader(inputPath))
                {
                    string line = fileReader.ReadLine();
                    while (line != null)
                    {
                        string[] lineArgs = line.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var lineArg in lineArgs)
                        {
                            if (words[0] == lineArg)
                            {
                                outputDict[words[0]] += 1;
                            }
                            else if (words[1] == lineArg)
                            {
                                outputDict[words[1]] += 1;
                            }
                            else if (words[2] == lineArg)
                            {
                                outputDict[words[2]] += 1;
                            }
                        }
                        line = fileReader.ReadLine();
                    }
                }
            }
            using (var fileWriter = new StreamWriter(@"C:\Users\Khaoz\Documents\visual studio 2015\Projects\SoftUni Exercises\Files and Directories\03. WordCount\Output.txt", false))
            {
                foreach (var i in outputDict)
                {
                    fileWriter.WriteLine(i.Key + " - " + i.Value);
                }
            }
            //Fuck doesnt work
        }
    }
}
