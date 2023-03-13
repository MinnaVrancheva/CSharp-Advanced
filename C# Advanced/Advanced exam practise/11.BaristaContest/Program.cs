using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.BaristaContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> ratios = new Dictionary<string, List<int>>();
            ratios["Croissant"] = new List<int>();
            ratios["Croissant"].Add(50);
            ratios["Croissant"].Add(50);
            ratios["Muffin"] = new List<int>();
            ratios["Muffin"].Add(40);
            ratios["Muffin"].Add(60);
            ratios["Baguette"] = new List<int>();
            ratios["Baguette"].Add(30);
            ratios["Baguette"].Add(70);
            ratios["Bagel"] = new List<int>();
            ratios["Bagel"].Add(20);
            ratios["Bagel"].Add(80);

            Queue<double> water = new Queue<double>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                );
            Stack<double> flour = new Stack<double>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                );

            SortedDictionary<string, int> baked = new SortedDictionary<string, int>();
            foreach (var item in ratios)
            {
                baked.Add(item.Key, 0);
            }

            while(water.Any() && flour.Any())
            {
                bool isFound = false;
                int waterPercentage = (int)(water.Peek() * 100 / (water.Peek() + flour.Peek()));
                int flourPercentage = 100 - waterPercentage;

                foreach (var item in ratios)
                {
                    if (item.Value[0] == waterPercentage)
                    {
                        isFound = true;
                        baked[item.Key] += 1;
                        water.Dequeue();
                        flour.Pop();
                        break;
                    }
                }

                if (!isFound)
                {
                    baked["Croissant"] += 1;
                    double flourLeft = flour.Peek() - water.Peek();
                    flour.Pop();
                    water.Dequeue();
                    flour.Push(flourLeft);
                    flour.Reverse();
                }
            }

            foreach (var item in baked.OrderByDescending(i => i.Value))
            {
                if (item.Value != 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            if (!water.Any())
            {
                Console.WriteLine($"Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }

            if (!flour.Any())
            {
                Console.WriteLine($"Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
