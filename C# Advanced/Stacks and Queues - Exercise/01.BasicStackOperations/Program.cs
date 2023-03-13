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

Stack<int> stack = new Stack<int>();

for (int i = 0; i < commands[0]; i++)
{
    stack.Push(elements[i]);
}
for (int i = 0; i < commands[1]; i++)
{
    stack.Pop();
}
if (!stack.Any())
{
    Console.WriteLine("0");
}
else if (stack.Contains(commands[2]))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}

