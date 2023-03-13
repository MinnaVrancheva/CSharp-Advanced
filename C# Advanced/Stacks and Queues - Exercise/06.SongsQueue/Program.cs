using System;
using System.Collections.Generic;

Queue<string> songs = new(
    Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (songs.Any())
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = command[0];
   

    switch (action)
    {
        case "Play":
            songs.Dequeue();
            break;
        case "Add":
            string song = string.Join(" ", command.Skip(1));
            if (songs.Contains(song))
            {
                Console.WriteLine($"{song} is already contained!");
                break;
            }
            songs.Enqueue(song);
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songs));
            break;
    }
}
Console.WriteLine($"No more songs!");
