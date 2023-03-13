int numberOfInputs = int.Parse(Console.ReadLine());
SortedSet<string> inputs = new SortedSet<string>();

for (int i = 0; i < numberOfInputs; i++)
{
    string[] input = Console.ReadLine()
        .Split();
    
    for (int j = 0; j < input.Length; j++)
    {
        inputs.Add(input[j]);
    }
}

Console.WriteLine(string.Join(" ", inputs));