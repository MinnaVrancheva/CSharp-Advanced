using System;
using System.Linq;

int squareMatrixSize = int.Parse(Console.ReadLine());
int[,] squareMatrix = new int[squareMatrixSize, squareMatrixSize];

FillInMatrix(squareMatrixSize, squareMatrix);

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int row = 0; row < squareMatrix.GetLength(0); row++)
{
    primaryDiagonalSum += squareMatrix[row, row];
}

for (int col = squareMatrix.GetLength(0) - 1; col >= 0; col--)
{
    secondaryDiagonalSum += squareMatrix[col, squareMatrixSize - 1 - col];
}

Console.WriteLine($"{Math.Abs(primaryDiagonalSum - secondaryDiagonalSum)}");

static int[,] FillInMatrix(int squareMatrixSize, int[,] squareMatrix)
{
    for (int i = 0; i < squareMatrixSize; i++)
    {
        int[] matrixElements = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int j = 0; j < matrixElements.Length; j++)
        {
            squareMatrix[i, j] = matrixElements[j];
        }
    }
    return squareMatrix;
}
