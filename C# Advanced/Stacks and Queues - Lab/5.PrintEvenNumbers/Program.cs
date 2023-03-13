namespace _5.PrintEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {               
                if (numbers[i] % 2 == 0)
                {
                    queue.Enqueue(numbers[i]);
                }
            }
            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
