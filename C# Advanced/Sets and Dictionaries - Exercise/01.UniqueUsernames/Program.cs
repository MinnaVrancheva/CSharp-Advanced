HashSet<string> userNames = new HashSet<string>();
int inputsNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputsNumber; i++)
{    
    userNames.Add(Console.ReadLine());
}

foreach (string name in userNames)
{
    Console.WriteLine(name);
}