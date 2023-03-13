namespace _6.Supermarket
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    Console.WriteLine(string.Join("\n", queue));
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
