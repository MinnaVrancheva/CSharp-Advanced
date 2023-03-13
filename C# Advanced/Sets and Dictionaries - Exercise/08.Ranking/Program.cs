Dictionary<string, string> contestsPasswords = new Dictionary<string, string>();
string command;

while((command = Console.ReadLine()) != "end of contests")
{
    string contest = command.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
    string password = command.Split(":", StringSplitOptions.RemoveEmptyEntries)[1];

    contestsPasswords.Add(contest, password);
}

SortedDictionary<string, Dictionary<string, int>> results = new SortedDictionary<string, Dictionary<string, int>>();
string command2;
int currentPoints = 0;

while ((command2 = Console.ReadLine()) != "end of submissions")
{
    string contest = command2.Split("=>", StringSplitOptions.RemoveEmptyEntries)[0];
    string password = command2.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
    string userName = command2.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2];
    int points = int.Parse(command2.Split("=>", StringSplitOptions.RemoveEmptyEntries)[3]);

    if (!contestsPasswords.ContainsKey(contest) || !contestsPasswords[contest].Contains(password))
    {
        continue;
    }

    if (!results.ContainsKey(userName))
    {
        results.Add(userName, new Dictionary<string, int>());
    }
    if (!results[userName].ContainsKey(contest))
    {
        results[userName].Add(contest, currentPoints);
    }
    if (results[userName][contest] < points)
    {
        results[userName][contest] = points;
    }
}


Console.WriteLine($"Best candidate is {results.MaxBy(c => c.Value.Values.Sum()).Key} with total {results.Values.Max(r => r.Values.Sum())} points.");

Console.WriteLine($"Ranking: ");

foreach (var student in results)
{
    Console.WriteLine(student.Key);
    Dictionary<string, int> orderedResults = student.Value
        .OrderByDescending(c => c.Value)
        .ToDictionary(c => c.Key, c => c.Value);

    foreach (var contest in orderedResults)
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}
