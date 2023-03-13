using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.FlowerWreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );
            Queue<int> roses = new Queue<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );

            
            int wreathsCount = 0;
            int flowersLeft = 0;

            while (lilies.Any() && roses.Any())
            {
                int currentLilie = lilies.Peek();
                int currentRose = roses.Peek();

                if (currentLilie + currentRose == 15)
                {
                    wreathsCount++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (currentLilie + currentRose > 15)
                {
                    for (int i = currentLilie + currentRose; i >= 15; i--)
                    {
                        currentLilie -= 2;
                        if (currentLilie + currentRose == 15)
                        {
                            wreathsCount++;
                            lilies.Pop();
                            roses.Dequeue();
                            break;
                        }
                        else if ((currentLilie + currentRose) < 15)
                        {
                            flowersLeft += currentLilie + roses.Dequeue();
                            lilies.Pop();
                            break;
                        }
                    }
                }
                else if (currentLilie + currentRose < 15)
                {
                    flowersLeft += lilies.Pop() + roses.Dequeue();
                }
            }

            if (flowersLeft >= 15)
            {
                for (int i = flowersLeft; i >= 15; i-= 15)
                {
                    flowersLeft -= 15;
                    wreathsCount++;
                }
            }
            
            if (wreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsCount} wreaths more!");
            }
        }

        //private static Stack<int> ReverseStack(Stack<int> lilies)
        //{
        //    Stack<int> temp = new Stack<int>();

        //    while (lilies.Any())
        //    {
        //        temp.Push(lilies.Pop());
        //    }

        //    return temp;
        //}

    }
}
