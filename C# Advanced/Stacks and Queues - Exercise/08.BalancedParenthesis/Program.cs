using System;
using System.Collections.Generic;

string parentesis = Console.ReadLine();
Stack<char> currentParentesis = new Stack<char>();

foreach (char ch in parentesis)
{
    switch (ch)
    {
        case '{':
        case '[':
        case '(':
            currentParentesis.Push(ch);
            break;
        case '}':
            if (currentParentesis.Count == 0 || currentParentesis.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ']':
            if (currentParentesis.Count == 0 || currentParentesis.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ')':
            if (currentParentesis.Count == 0 || currentParentesis.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
    }
}
Console.WriteLine("YES");

