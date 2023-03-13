SortedDictionary<string, Dictionary<string, int>> participants = new SortedDictionary<string, Dictionary<string, int>>();
SortedDictionary<string, int> languageSubmissionsCount = new SortedDictionary<string, int>();

int currentPoints = 0;
string command;

while ((command = Console.ReadLine()) != "exam finished")
{
    string[] command2 = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
    string userName = command2[0];
   

    if (command2[1] == "banned")
    {
        participants.Remove(userName);
        continue;
    }

    string language = command2[1];
    int points = int.Parse(command2[2]);

    if (!participants.ContainsKey(userName))
    {
        participants.Add(userName, new Dictionary<string, int>());
    }

    if (!participants[userName].ContainsKey(language))
    {
        participants[userName].Add(language, currentPoints);
    }

    if (participants[userName][language] < points)
    {
        participants[userName][language] = points;
    }

    if (!languageSubmissionsCount.ContainsKey(language))
    {
        languageSubmissionsCount.Add(language, 1);
        continue;

    }

    languageSubmissionsCount[language]++;
}

Console.WriteLine("Results:");

foreach (var (user, languages) in participants.OrderByDescending(x => x.Value.Values.Max()))
{
    foreach (var (languageName, languagePoints) in languages)
    {
        Console.WriteLine($"{user} | {languagePoints}");
    }
}

Console.WriteLine("Submissions:");
foreach (var language in languageSubmissionsCount.OrderByDescending(c => c.Value))
{
    Console.WriteLine($"{language.Key} - {language.Value}");
}

