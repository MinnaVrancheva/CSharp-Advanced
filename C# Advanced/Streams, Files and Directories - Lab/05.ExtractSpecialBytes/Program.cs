namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                byte[] readBytes = File.ReadAllBytes(binaryFilePath);
                StringBuilder sb = new StringBuilder();

                var bytesList = new List<string>();
                while (!reader.EndOfStream)
                {
                    bytesList.Add(reader.ReadLine());
                }

                foreach (var item in readBytes)
                {
                    if (bytesList.Contains(item.ToString()))
                    {
                        sb.Append(item.ToString());
                    }
                }

                using StreamWriter streamWriter = new StreamWriter(outputPath);
                streamWriter.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
