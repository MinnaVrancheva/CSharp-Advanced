using System.Linq;

Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();
Dictionary<string, int> vloggerFollowing = new Dictionary<string, int>();
string command;

while((command = Console.ReadLine()) != "Statistics")
{
    string vloggerName = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
    string actionType = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

    switch (actionType)
    {
        case "joined":

            if (!vloggers.ContainsKey(vloggerName) || !vloggerFollowing.ContainsKey(vloggerName))
            {
                vloggers.Add(vloggerName, new List<string>());
                vloggerFollowing.Add(vloggerName, 0);
            }

            break;
        case "followed":
            string vloggerToFollow = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

            if (!vloggers.ContainsKey(vloggerName) || !vloggers.ContainsKey(vloggerToFollow) || vloggerName == vloggerToFollow)
            {
                continue;
            }
            if (vloggers[vloggerToFollow].Contains(vloggerName))
            {
                continue;
            }

            vloggers[vloggerToFollow].Add(vloggerName);
            vloggerFollowing[vloggerName] += 1;
            break;
    }
}


Console.WriteLine($"The V-Logger has a total of {vloggers.Count()} vloggers in its logs.");
int count = 1;
Dictionary<string, List<string>> orderedVloggers = vloggers
    .OrderByDescending(x => x.Value.Count)
    .ThenBy(vloggers => vloggerFollowing.FirstOrDefault(vloggerFollowing => vloggerFollowing.Key == vloggers.Key).Value)
    .ToDictionary(item => item.Key, item => item.Value);


foreach (var vlogger in orderedVloggers)
{
    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Count} followers, {vloggerFollowing[vlogger.Key]} following");

    if (count == 1)
    {
        foreach (string item in vlogger.Value.OrderBy(v => v).ToList())
        {
            Console.WriteLine($"*  {item}");
        }
    }

    count++;
}

