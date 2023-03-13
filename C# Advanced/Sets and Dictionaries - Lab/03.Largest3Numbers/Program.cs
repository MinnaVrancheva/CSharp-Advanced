using System;
using System.Collections.Generic;
using System.Linq;

int[] inputNumbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .OrderByDescending(x => x)
    .ToArray();
int[] topThree = new int[3];

int count = inputNumbers.Length >= 3 ? 3 : inputNumbers.Length;

for (int i = 0; i < count; i++)
{
    Console.Write($"{inputNumbers[i]} ");
}
