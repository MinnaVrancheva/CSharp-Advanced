using System;


int numberOfPetrolPumps = int.Parse(Console.ReadLine());
Queue<int[]> pumps = new Queue<int[]>();


for (int i = 0; i <= numberOfPetrolPumps - 1; i++)
{
    int[] items = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    pumps.Enqueue(items);
}

int smallestIndex = 0;

while (true)
{
    int fuelLeft = 0;

    foreach (var item in pumps)
    {
        fuelLeft += item[0];
        fuelLeft -= item[1];

        if (fuelLeft < 0)
        {
            int[] currentElement = pumps.Dequeue();
            pumps.Enqueue(currentElement);
            smallestIndex++;
            break;
        }
    }
    if (fuelLeft >= 0)
    {
        Console.WriteLine(smallestIndex);
        break;
    }
}
