HashSet<string> uniqueNames = new HashSet<string>();
int numberOfInputs = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfInputs; i++)
{
    string input = Console.ReadLine();
    uniqueNames.Add(input);
}

foreach (string uniqueName in uniqueNames)
{
    Console.WriteLine(uniqueName);
}
