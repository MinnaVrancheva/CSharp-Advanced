namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputPath, string outputPath)
        {
            using (var reader = new StreamReader(inputPath))
            {
                string line = reader.ReadLine();
                int counter = 1;
                using (var writer = new StreamWriter(outputPath))
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                        line = reader.ReadLine();
                    }
            }
        }
    }
}
