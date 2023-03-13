using System;
using System.Collections.Generic;
using System.Linq;

int amountOfFood = int.Parse(Console.ReadLine());
Queue<int> orders = new(
    Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    );

Console.WriteLine(orders.Max());

while (orders.Any())
{
    int currentOrder = orders.Peek();
    
    if (amountOfFood < currentOrder)
    {
        break;
    }

    currentOrder = orders.Dequeue();
    amountOfFood -= currentOrder;
}
if (orders.Any())
{
    Console.Write($"Orders left: {string.Join(" ", orders)}");
}
else
{
    Console.WriteLine($"Orders complete");
}

  

