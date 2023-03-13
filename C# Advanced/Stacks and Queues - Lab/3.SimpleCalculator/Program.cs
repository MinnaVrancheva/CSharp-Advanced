namespace _3.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ');
            Stack<string> stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            int currentNumber = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());
                
                if (operation == "-")
                {
                    currentNumber -= secondNumber;
                }
                else if (operation == "+")
                {
                    currentNumber += secondNumber;
                }
            }

            Console.WriteLine(currentNumber);
        }
    }
}
