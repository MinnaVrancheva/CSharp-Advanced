using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numberOfIngredients = new Queue<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                );
            Stack<int> freshnessLevels = new Stack<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                );

            Dictionary<string, int> dishesMap = new Dictionary<string, int>();
            dishesMap["Dipping sauce"] = 150;
            dishesMap["Green salad"] = 250;
            dishesMap["Chocolate cake"] = 300;
            dishesMap["Lobster"] = 400;

            SortedDictionary<string, int> cookedDishes = new SortedDictionary<string, int>();

            while (numberOfIngredients.Any() && freshnessLevels.Any())
            {
                int totalFreshness = numberOfIngredients.Peek() * freshnessLevels.Peek();

                if (numberOfIngredients.Peek() == 0)
                {
                    numberOfIngredients.Dequeue();
                    continue;
                }

                if (dishesMap.ContainsValue(totalFreshness))
                {
                    if (!cookedDishes.Keys.Contains(dishesMap.FirstOrDefault(d => d.Value == totalFreshness).Key))
                    {
                        cookedDishes.Add(dishesMap.FirstOrDefault(d => d.Value == totalFreshness).Key, 1);

                    }
                    else
                    {
                        cookedDishes[dishesMap.FirstOrDefault(d => d.Value == totalFreshness).Key] += 1;
                    }
                    
                    numberOfIngredients.Dequeue();
                    freshnessLevels.Pop();
                }
                else
                {
                    freshnessLevels.Pop();
                    int currentIngredientValue = numberOfIngredients.Peek();
                    currentIngredientValue += 5;
                    numberOfIngredients.Dequeue();
                    numberOfIngredients.Enqueue(currentIngredientValue);
                }
            }

            if (cookedDishes.Count >= 4)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
            }

            if (numberOfIngredients.Any())
            {
                Console.WriteLine($"Ingredients left: {numberOfIngredients.Sum()}");
            }

            foreach (var dis in cookedDishes)
            {
                if (dis.Value > 0)
                {
                    Console.WriteLine($" # {dis.Key} --> {dis.Value}");
                }
            }
        }
    }
}
