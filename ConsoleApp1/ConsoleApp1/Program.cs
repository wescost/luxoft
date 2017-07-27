using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"Data\data.txt");
            var wordsList = text.Split(new Char[] { ' ', ';', '\"', ',',':' }, StringSplitOptions.RemoveEmptyEntries);

            using (StreamWriter writetext = new StreamWriter(@"Data\result.txt"))
            {
                var y = 0;
                foreach (var word in wordsList)
                {
                    if (word != "*")
                    {
                        int counter = 0;
                        writetext.Write(word + " ");
                        for (int i = y; i < wordsList.Length; i++)
                        {
                            if (word == wordsList[i])
                            {
                                counter++;
                                wordsList[i] = "*";
                            }
                        }
                        writetext.WriteLine(counter);
                        y++;
                    }

                }
            }
        }
    }
}
