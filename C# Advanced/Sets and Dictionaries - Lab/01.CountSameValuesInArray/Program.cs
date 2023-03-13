using System;
using System.Linq;
using System.Collections.Generic;

Dictionary<double, int> counts = new Dictionary<double, int>();

double[] input = Console.ReadLine()
    .Split(' ')
    .Select(double.Parse)
    .ToArray();

foreach (var number in input)
{
    if (!counts.ContainsKey(number))
    {
        counts.Add(number, 0);
    }

    counts[number]++;
}

foreach (var number in counts)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}
