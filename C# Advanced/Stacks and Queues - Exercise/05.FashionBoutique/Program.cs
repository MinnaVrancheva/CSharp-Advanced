using System;
using System.Collections.Generic;

Stack<int> clothesInABox = new(
    Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    );
int ragCapacity = int.Parse(Console.ReadLine());
int numberOfRags = 1;
int currentRagCapacity = ragCapacity;

while (clothesInABox.Any())
{
    currentRagCapacity -= clothesInABox.Peek();

    if (currentRagCapacity < 0)
    {
        numberOfRags++;
        currentRagCapacity = ragCapacity;
        continue;
    }
    
    clothesInABox.Pop();
}
Console.WriteLine(numberOfRags);

