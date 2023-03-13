using System;
using System.Collections.Generic;
using System.Linq;

int numberOfQueries = int.Parse(Console.ReadLine());
Stack<int> queries = new Stack<int>();

for (int i = 0; i < numberOfQueries; i++)
{
    int[] command = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    switch (command[0])
    {
        case 1: 
            queries.Push(command[1]);
            break;
        case 2:
            queries.Pop();
            break;
        case 3:
            if (queries.Any())
            {
                Console.WriteLine(queries.Max());
            }
            break;
        case 4:
            if (queries.Any())
            {
                Console.WriteLine(queries.Min());
            }
            break;
    }
}
Console.WriteLine(string.Join(", ", queries));

