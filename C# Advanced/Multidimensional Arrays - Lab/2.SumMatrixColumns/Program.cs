using System;
using System.Linq;

int[] matrixSize = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] colElements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = Convert.ToInt32(colElements[col]);
    }
}

for (int col = 0; col < matrix.GetLength(1); col++)
{
    int elementsSum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        elementsSum += matrix[row, col];        
    }
    Console.WriteLine(elementsSum);
}
