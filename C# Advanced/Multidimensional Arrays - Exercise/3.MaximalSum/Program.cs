using System;
using System.Linq;

int[] matrixDimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = matrixDimensions[0];
int cols = matrixDimensions[1];
int[,] matrix = new int[rows, cols];

FillMatrixWithGivenElements(rows, cols, matrix);

int maxSum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        int currentSum = 0;

        if (col + 2 < cols && row + 2 < rows)
        {
            currentSum = 
                matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
        }

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxCol = col;
            maxRow = row;
        }
        
    }
}

Console.WriteLine($"Sum = {maxSum}");
for (int row = maxRow; row < maxRow + 3; row++)
{
    for (int col = maxCol; col < maxCol + 3; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}

static void FillMatrixWithGivenElements(int rows, int cols, int[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {
        int[] matrixElements = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = matrixElements[col];
        }
    }
}


