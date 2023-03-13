using System;
using System.Collections.Generic;
using System.Text;

int numberOfCommand = int.Parse(Console.ReadLine());
Stack<string> newString = new Stack<string>();
string newText = "";

for (int i = 0; i < numberOfCommand; i++)
{
    string[] commandArg = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string commandArg1 = commandArg[0];
    
    switch (commandArg1)
    {
        case "1":
            string commandArg2 = commandArg[1];
            newString.Push(newText);
            newText += commandArg2;
            break;
        case "2":
            int count = int.Parse(commandArg[1]);
            newString.Push(newText);
            newText = newText.Remove(newText.Length - count);
            break;
        case "3":
            int index = int.Parse(commandArg[1]) - 1;
            Console.WriteLine(newText[index]);
            break;
        case "4":
            newText = newString.Pop();
            break;
    }
}


