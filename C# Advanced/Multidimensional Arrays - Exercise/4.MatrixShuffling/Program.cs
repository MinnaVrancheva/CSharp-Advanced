using System;
using System.Linq;

int[] matrixDimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = matrixDimensions[0];
int columns = matrixDimensions[1];
string[,] matrix = new string[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = input[j];
    }
}

string command;
while ((command = Console.ReadLine().ToLower()) != "end")
{
    int count = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;

    if (count < 5 || count > 5)
    {
        Console.WriteLine($"Invalid input!");
        continue;
    }

    string inputArg1 = command.Split()[0];
    int row1 = int.Parse(command.Split()[1]);
    int col1 = int.Parse(command.Split()[2]);
    int row2 = int.Parse(command.Split()[3]);
    int col2 = int.Parse(command.Split()[4]);

    if (inputArg1 != "swap" || row1 < 0 || row1 > matrix.GetLength(0) || row2 < 0 || row2 > matrix.GetLength(0) || col1 < 0 || col1 > matrix.GetLength(1) || col2 < 0 || col2 > matrix.GetLength(1))
    {
        Console.WriteLine($"Invalid input!");
        continue;
    }

    string parameterFirst = matrix[row1, col1];
    matrix[row1, col1] = matrix[row2, col2];
    matrix[row2, col2] = parameterFirst;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}

