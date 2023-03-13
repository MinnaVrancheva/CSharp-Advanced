using System;
using System.Linq;

int[] matrixSize = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] colElements = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();

    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = Convert.ToInt32(colElements[j]);
    }
}

int count = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        count += matrix[row, col];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(count);