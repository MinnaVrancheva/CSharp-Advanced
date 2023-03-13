using System;
using System.Linq;

int numberOfRows = int.Parse(Console.ReadLine());
int[][] jaggedMatrix = new int[numberOfRows][];

for (int rows = 0; rows < numberOfRows; rows++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    jaggedMatrix[rows] = new int[input.Length];

    for (int col = 0; col < input.Length; col++)
    {
        jaggedMatrix[rows][col] = input[col];
    }
}

for (int row = 0; row < numberOfRows - 1; row++)
{
    if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
    {
        for (int col = 0; col < jaggedMatrix[row].Length; col++)
        {
            jaggedMatrix[row][col] *= 2;
            jaggedMatrix[row+1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jaggedMatrix[row].Length; col++)
        {
            jaggedMatrix[row][col] /= 2;
        }
        for (int col = 0; col < jaggedMatrix[row + 1].Length; col++)
        {
            jaggedMatrix[row + 1][col] /= 2;
        }
    }
}

string command;
while ((command = Console.ReadLine()) != "End")
{
    string commandArg1 = command.Split()[0];
    int row = int.Parse(command.Split()[1]);
    int column = int.Parse(command.Split()[2]);
    int value = int.Parse(command.Split()[3]);

    switch (commandArg1)
    {
        case "Add":
            if (row >= 0 && column >= 0 && row < jaggedMatrix.Length && column < jaggedMatrix[row].Length)
            {
                jaggedMatrix[row][column] += value;
            }
            break;
        case "Subtract":
            if (row >= 0 && column >= 0 && row < jaggedMatrix.Length && column < jaggedMatrix[row].Length)
            {
                jaggedMatrix[row][column] -= value;
            }
            break;
    }
}

for (int row = 0; row < jaggedMatrix.Length; row++)
{
    for (int col = 0; col < jaggedMatrix[row].Length; col++)
    {
        Console.Write($"{jaggedMatrix[row][col]} ");
    }
    Console.WriteLine();
}
