namespace _2.StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            Stack<int> elements = new Stack<int>();

            foreach (int i in input)
            {
                elements.Push(i);
            }

            var command = Console.ReadLine().ToLower();

            while(command != "end")
            {
                var commandTokens = command.Split(' '); 
                var commandToExecute = commandTokens[0];

                if (commandToExecute == "add")
                {
                    int n1 = int.Parse(commandTokens[1]);
                    int n2 = int.Parse(commandTokens[2]);
                    elements.Push(n1);
                    elements.Push(n2);
                }
                else if (commandToExecute == "remove")
                {
                    int n1 = int.Parse(commandTokens[1]);
                    if (elements.Count >= n1)
                    {
                        for (int i = 0; i < n1; i++)
                        {
                            elements.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int sumOfElements = elements.Sum();
            Console.WriteLine($"Sum: {sumOfElements}");
        }
    }
}
