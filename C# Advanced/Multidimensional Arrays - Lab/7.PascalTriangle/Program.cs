using System;
using System.Linq;

int pascalTriangleSize = int.Parse(Console.ReadLine());

long[][] jaggedMatrix = new long[pascalTriangleSize][];
jaggedMatrix[0] = new long[1] { 1 };

for (int i = 1; i < pascalTriangleSize; i++)
{
    jaggedMatrix[i] = new long[i + 1];

    for (int j = 0; j < jaggedMatrix[i].Length; j++)
    {
        if (jaggedMatrix[i - 1].Length > j)
        {
            jaggedMatrix[i][j] += jaggedMatrix[i - 1][j];
        }
        
        if (j > 0)
        {
            jaggedMatrix[i][j] += jaggedMatrix[i - 1][j - 1];
        }
    }
}

PrintingJaggedArrays(jaggedMatrix);

static void PrintingJaggedArrays(long[][] jaggedMatrix)
{
    for (int row = 0; row < jaggedMatrix.Length; row++)
    {
        for (int col = 0; col < jaggedMatrix[row].Length; col++)
        {
            Console.Write($"{jaggedMatrix[row][col]} ");
        }
        Console.WriteLine();
    }
}
