using System;
using System.Linq;

int jaggedMatrixRaws = int.Parse(Console.ReadLine());
int[][] jaggedMatrix = new int[jaggedMatrixRaws][];

for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
{
    jaggedMatrix[row] = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}

string command;
while ((command = Console.ReadLine().ToLower()) != "end")
{
    string actionType = command.Split(' ')[0];
    int row = int.Parse(command.Split(' ')[1]);
    int col = int.Parse(command.Split(' ')[2]);
    int value = int.Parse(command.Split(' ')[3]);

    if (row < 0 || col < 0 || row >= jaggedMatrix.Length || col >= jaggedMatrix[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    switch (actionType)
    {
        case "add":
            jaggedMatrix[row][col] += value;
            break;
        case "subtract":
            jaggedMatrix[row][col] -= value;
            break;
    }
}

PrintingJaggedArrays(jaggedMatrix);

static void PrintingJaggedArrays(int[][] jaggedMatrix)
{
    for (int row = 0; row < jaggedMatrix.Length; row++)
    {
        for (int col = 0; col < jaggedMatrix[row].Length; col++)
        {
            Console.Write($"{jaggedMatrix[row][col]} ");
        }
        Console.WriteLine();
    }
}
