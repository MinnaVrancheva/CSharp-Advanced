using System;
using System.Linq;

int[] matrixDimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
string snake = Console.ReadLine();

int rows = matrixDimensions[0];
int cols = matrixDimensions[1];
char[,] matrix = new char[rows, cols];
int count = 0;

for (
    int row = 0; row < rows; row++)
{
    if (row % 2 != 0)
    {
        for (int col = cols -1; col >= 0; col--)
        {
            if (count == snake.Length)
            {
                count = 0;
            }
            
            matrix[row, col] = snake[count];
            count++;
        }
    }

    else
    {
        for (int col = 0; col < cols; col++)
        {
            if (count == snake.Length)
            {
                count = 0;
            }
            
            matrix[row, col] = snake[count];
            count++;
        }
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write($"{matrix[row, col]}");
    }
    Console.WriteLine();
}