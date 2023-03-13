using System;
using System.Linq;

int[] matrixSize = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];

FillInMatrix(rows, cols, matrix);

int sum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        int currentSum = 0;

        if (row >= matrix.GetLength(0) - 1 || col >= matrix.GetLength(1) - 1)
        {
            continue;
        }
        currentSum += matrix[row, col];
        currentSum += matrix[row + 1, col];
        currentSum += matrix[row, col + 1];
        currentSum += matrix[row + 1, col + 1];

        if (currentSum > sum)
        {
            sum = currentSum;
            maxRow = row;
            maxCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
Console.WriteLine(sum);

static int[,] FillInMatrix(int rows, int cols, int[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {
        int[] colElements = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = Convert.ToInt32(colElements[col]);
        }
    }
    return matrix;
}