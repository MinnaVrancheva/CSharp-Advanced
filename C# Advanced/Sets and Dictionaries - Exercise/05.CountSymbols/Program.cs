string input = Console.ReadLine();
SortedDictionary<char, int> result = new SortedDictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char letter = input[i];
    if (!result.ContainsKey(letter))
    {
        result[letter] = 1;
    }
    else
    {
        result[letter]++;
    }
}

foreach (var letter in result)
{
    Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
}
