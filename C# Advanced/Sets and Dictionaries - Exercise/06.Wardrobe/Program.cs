Dictionary<string, Dictionary<string, int>> clothesByColor = new Dictionary<string, Dictionary<string, int>>();
int inputNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputNumber; i++)
{
    string[] input1 = Console.ReadLine()
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    string color = input1[0];
    string[] clothes = input1[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

    for (int j = 0; j < clothes.Length; j++)
    {
        if (!clothesByColor.ContainsKey(color))
        {
            clothesByColor.Add(color, new Dictionary<string, int>());
        }
        if (!clothesByColor[color].ContainsKey(clothes[j]))
        {
            clothesByColor[color].Add(clothes[j], 1);
        }
        else
        {
            clothesByColor[color][clothes[j]]++;
        }
    }
}

string[] lookingFor = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
string colorToLookFor = lookingFor[0];
string clothingTypeToLookFor = lookingFor[1];

foreach (var color in clothesByColor)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var cloth in color.Value)
    {
        if (color.Key == colorToLookFor && cloth.Key == clothingTypeToLookFor)
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
        }
    }
}

