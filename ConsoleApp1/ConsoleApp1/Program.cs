using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"Data\data.txt");
            var wordsList = text.Split(new Char[] { ' ', ';', '\"', ',',':' }, StringSplitOptions.RemoveEmptyEntries);
            var dictionary =new Dictionary<string, int>();

            foreach (var word in wordsList)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                    continue;
                }

                dictionary[word] = 1;
            }

            using (StreamWriter writer = new StreamWriter(@"Data\result.txt"))
            {
                foreach (var item in dictionary)
                {
                    writer.WriteLine($"{item.Key} {item.Value}");
                }
            }
        }
    }
}
