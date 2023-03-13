
Stack<int> foodPortionsQuantities = new Stack<int>(
    Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray()
    );
Queue<int> staminaQuantities = new Queue<int>(
    Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray()
    );

Dictionary<string, int> peaks = new Dictionary<string, int>();
peaks["Vihren"] = 80;
peaks["Kutelo"] = 90;
peaks["Banski Suhodol"] = 100;
peaks["Polezhan"] = 60;
peaks["Kamenitza"] = 70;

List<string> conqueredPeaks = new List<string>();

while (peaks.Any() && foodPortionsQuantities.Any() && staminaQuantities.Any())
{
    int n1 = foodPortionsQuantities.Peek();
    int n2 = staminaQuantities.Peek();
    KeyValuePair<string, int> difficultyLevel = peaks.ElementAt(0);
    int difficulty = difficultyLevel.Value;
    string difficultyName = difficultyLevel.Key;

    if (n1 + n2 >= difficulty)
    {
        foodPortionsQuantities.Pop();
        staminaQuantities.Dequeue();
        conqueredPeaks.Add(difficultyName);
        peaks.Remove(difficultyName);
    }
    else
    {
        foodPortionsQuantities.Pop();
        staminaQuantities.Dequeue();
    }
}

if (peaks.Any())
{
    Console.WriteLine($"Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
else
{
    Console.WriteLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}

if (conqueredPeaks.Any())
{
    Console.WriteLine($"Conquered peaks:");
    Console.WriteLine(String.Join(Environment.NewLine, conqueredPeaks));
}