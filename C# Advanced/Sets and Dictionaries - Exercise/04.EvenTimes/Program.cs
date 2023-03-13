Dictionary<int, int> numbers = new Dictionary<int, int>();
int numbrOfinputs = int.Parse(Console.ReadLine());

for (int i = 0; i < numbrOfinputs; i++)
{
    int input = int.Parse(Console.ReadLine());
    
    if (!numbers.ContainsKey(input))
    {
        numbers.Add(input, 1);
    }
    else
    {
        numbers[input]++;
    }
}

foreach (int input in numbers.Keys)
{
    if (numbers[input] % 2 == 0)
    {
        Console.WriteLine(input);
    }
}
