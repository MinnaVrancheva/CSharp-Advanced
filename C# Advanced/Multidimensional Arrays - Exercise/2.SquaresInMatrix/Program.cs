using System;
using System.Linq;

int[] matrixDimensions = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int rows = matrixDimensions[0];
int cols = matrixDimensions[1];
char[,] matrix = new char[rows, cols];

for (int i = 0; i < rows; i++)
{
    string[] matrixCharacters = Console.ReadLine()
        .Split();

    for (int j = 0; j < cols; j++)
    {
        char character = char.Parse(matrixCharacters[j]);
        matrix[i, j] = character;
    }
}

int numberOfSquareMatrixes = 0;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (col + 1 < cols && row + 1 < rows)
        {
            if (matrix[row, col] == matrix[row + 1, col] 
                && matrix[row, col + 1] == matrix[row + 1, col + 1]
                && matrix[row, col] == matrix[row, col + 1])
            {
                numberOfSquareMatrixes++;
            }
        }
    }
}

Console.WriteLine(numberOfSquareMatrixes);
