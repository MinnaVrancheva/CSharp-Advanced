namespace MergeFiles
{
    using System;
    using System.IO;
    using System.Text;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamWriter output = File.CreateText(outputFilePath))
            {
                string[] file1 = File.ReadAllLines(firstInputFilePath);
                string[] file2 = File.ReadAllLines(secondInputFilePath);
                int lineNumber = 0;

                while (lineNumber < file1.Length || lineNumber < file2.Length)
                {
                    if (lineNumber < file1.Length)
                    {
                        output.WriteLine(file1[lineNumber]);
                    }
                    if (lineNumber < file2.Length)
                    {
                        output.WriteLine(file2[lineNumber]);
                    }
                    lineNumber++;
                }
            }
        }
    }
}

