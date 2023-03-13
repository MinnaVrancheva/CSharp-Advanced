
Stack<int> milsOfCaffeine = new Stack<int> (
    Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray()
    );
Queue<int> energyDrinks = new Queue<int>(
    Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray()
    );

int totalCaffeine = 0;

while (milsOfCaffeine.Any() && energyDrinks.Any())
{
    int n1 = milsOfCaffeine.Peek();
    int n2 = energyDrinks.Peek();   

    if (n1 * n2 + totalCaffeine <= 300)
    {
        totalCaffeine += n1 * n2;
        milsOfCaffeine.Pop();
        energyDrinks.Dequeue();
    }

    else
    {
        milsOfCaffeine.Pop();
        energyDrinks.Dequeue();
        energyDrinks.Enqueue(n2);
        totalCaffeine -= 30;

        if (totalCaffeine < 0)
        {
            totalCaffeine = 0;
        }
    }
}

if (energyDrinks.Any())
{
    Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
}
else
{
    Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");


