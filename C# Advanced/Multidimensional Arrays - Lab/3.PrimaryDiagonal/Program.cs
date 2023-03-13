using System;
using System.Linq;

int squareSize = int.Parse(Console.ReadLine());
int[,] matrix = new int[squareSize, squareSize];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowsElements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = Convert.ToInt32(rowsElements[col]);
    }
}

int diagonalSum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    diagonalSum += matrix[row, row];
}

Console.WriteLine(diagonalSum);
