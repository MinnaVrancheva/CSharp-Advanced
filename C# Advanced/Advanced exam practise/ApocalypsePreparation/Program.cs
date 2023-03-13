
Queue<int> textiles = new Queue<int>(
    Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    );

Stack<int> medicaments = new Stack<int>(
    Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    );

Dictionary<string, int> map = new Dictionary<string, int>();
map["Patch"] = 30;
map["Bandage"] = 40;
map["MedKit"] = 100;

SortedDictionary<string, int> itemsCreated = new SortedDictionary<string, int>();

while (textiles.Any() && medicaments.Any())
{
    int sum = textiles.Peek() + medicaments.Peek();

    if (map.ContainsValue(sum))
    {
        textiles.Dequeue();
        medicaments.Pop();

        if (!itemsCreated.Keys.Contains(map.FirstOrDefault(d => d.Value == sum).Key))
        {
            itemsCreated.Add(map.FirstOrDefault(d => d.Value == sum).Key, 1);
        }
        else
        {
            itemsCreated[map.FirstOrDefault(d => d.Value == sum).Key] += 1;
        }
    }
    else if (!map.ContainsValue(sum))
    {
        if (sum == map["MedKit"])
        {
            textiles.Dequeue();
            medicaments.Pop();

            if (!itemsCreated.ContainsKey("MedKit"))
            {
                itemsCreated.Add("MedKit", 1);
            }
            else
            {
                itemsCreated["MedKit"] += 1;
            }

        }
        else if (sum > map["MedKit"])
        {
            if (!itemsCreated.ContainsKey("MedKit"))
            {
                itemsCreated.Add("MedKit", 1);
            }
            else
            {
                itemsCreated["MedKit"] += 1;
            }
            int difference = sum - 100;
            textiles.Dequeue();
            medicaments.Pop();
            medicaments.Push(medicaments.Pop() + difference);
        }
        else
        {
            textiles.Dequeue();
            medicaments.Push(medicaments.Pop() + 10);
        }
    }
}

if (!textiles.Any() && !medicaments.Any())
{
    Console.WriteLine($"Textiles and medicaments are both empty.");
}
else if (!textiles.Any())
{
    Console.WriteLine($"Textiles are empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine($"Medicaments are empty.");
}

foreach (var item in itemsCreated.OrderByDescending(i => i.Value))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (medicaments.Any())
{
    Console.Write($"Medicaments left: {string.Join(", ", medicaments)}");
    
}
if (textiles.Any())
{
    Console.Write($"Textiles left: {string.Join(", ", textiles)}");

}
