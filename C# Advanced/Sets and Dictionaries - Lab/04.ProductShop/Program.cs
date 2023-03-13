using System;
using System.Collections.Generic;

SortedDictionary<string, Dictionary<string, double>> shopsInfo = new SortedDictionary<string, Dictionary<string, double>>();

string command;
while((command = Console.ReadLine()) != "Revision")
{
    string shopName = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
    string product = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];
    double price = double.Parse(command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[2]);

    if (!shopsInfo.ContainsKey(shopName))
    {
        shopsInfo[shopName] = new Dictionary<string, double>();
    }
    if (!shopsInfo[shopName].ContainsKey(product))
    {
        shopsInfo[shopName][product] = price;
    }
    shopsInfo[shopName][product] = price;
}

foreach (var shopName in shopsInfo)
{
    Console.WriteLine($"{shopName.Key}-> ");

    foreach (var product in shopName.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}