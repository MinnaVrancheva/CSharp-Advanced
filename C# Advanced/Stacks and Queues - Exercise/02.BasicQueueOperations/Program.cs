using System;
using System.Collections.Generic;
using System.Linq;

int[] commands = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] elements = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>();

for (int i = 0; i < commands[0]; i++)
{
    queue.Enqueue(elements[i]);
}
for (int i = 0; i < commands[1]; i++)
{
    queue.Dequeue();
}
if (!queue.Any())
{
    Console.WriteLine("0");
}
else if (queue.Contains(commands[2]))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}

