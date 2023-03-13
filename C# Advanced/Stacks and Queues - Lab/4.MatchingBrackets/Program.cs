namespace _4.MatchingBrackets
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int openingBracketIndex = stack.Pop();
                    int closingBracketIndex = i;
                    string result = expression.Substring(openingBracketIndex, closingBracketIndex - openingBracketIndex + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
