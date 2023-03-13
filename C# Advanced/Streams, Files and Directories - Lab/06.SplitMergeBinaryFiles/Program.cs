namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;
    
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOnePath, string partTwoPath)
        {
            using FileStream fileStream = File.OpenRead(sourceFilePath);
            {
                byte[] size = File.ReadAllBytes(sourceFilePath);
                long size1 = size.Length;

                for (int i = 0; i < size1; i++)
                {
                    if (i % 2 != 0)
                    {
                        File.OpenWrite(partOnePath).Close();
                    }
                    if (i % 2 == 0)
                    {
                        File.OpenWrite(partTwoPath).Close();
                    }
                }
            }
        }

        public static void MergeBinaryFiles(string joinedFilePath)
        {


            //string[] scrJoined = { "partOnePath", "partTwoPath" };

            //using (Stream stream = File.Create(joinedFilePath))
            //{
            //    foreach (string src in scrJoined)
            //    {
            //        using Stream stream1 = File.Create(src);
            //        stream1.CopyTo(stream);
            //    }
            //}
        }
    }
}
