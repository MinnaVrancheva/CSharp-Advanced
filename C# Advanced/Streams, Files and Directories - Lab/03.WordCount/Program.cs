namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordPath, string textPath, string outputPath)
        {
            using var reader = new StreamReader(wordPath);
            {
                Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
                string[] allInputLines = File.ReadAllText(wordPath).Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] allLinesToCheck = File.ReadAllText(textPath).Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    foreach (string inputLine in allInputLines)
                    {
                        foreach (string input in allLinesToCheck)
                        {
                            if (inputLine.ToLower() == input.ToLower())
                            {
                                if (!keyValuePairs.ContainsKey(inputLine))
                                {
                                    keyValuePairs.Add(inputLine, 1);
                                }
                                else
                                {
                                    keyValuePairs[inputLine]++;
                                }
                            }
                        }
                    }
                    line = reader.ReadLine();
                }

                using var writer = new StreamWriter(outputPath);
                foreach (var item in keyValuePairs.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
