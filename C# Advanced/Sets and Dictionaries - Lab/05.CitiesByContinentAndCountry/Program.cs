using System;
using System.Collections.Generic;

Dictionary<string, Dictionary<string, List<string>>> continentsInfo = new Dictionary<string, Dictionary<string, List<string>>>();
int numberOfInput = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfInput; i++)
{
    string[] input = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string continent = input[0];
    string country = input[1];
    string city = input[2];

    if (!continentsInfo.ContainsKey(continent))
    {
        continentsInfo[continent] = new Dictionary<string, List<string>>();
    }

    if (!continentsInfo[continent].ContainsKey(country))
    {
        continentsInfo[continent][country] = new List<string>();
    }
    continentsInfo[continent][country].Add(city);
}

foreach (var continent in continentsInfo)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
    }
}
