int[] sets1And2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
HashSet<int> sets1 = new HashSet<int>();
HashSet<int> sets2 = new HashSet<int>();


for (int i = 0; i < sets1And2[0]; i++)
{
    int input = int.Parse(Console.ReadLine());
    sets1.Add(input);
}

for (int i = 0; i < sets1And2[1]; i++)
{
    int input = int.Parse(Console.ReadLine());
    sets2.Add(input);
}

sets1.IntersectWith(sets2);

Console.Write(string.Join(" ", sets1));



