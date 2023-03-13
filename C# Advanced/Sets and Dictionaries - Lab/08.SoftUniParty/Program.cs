HashSet<string> guests = new HashSet<string>();
string command;

while ((command = Console.ReadLine()) != "PARTY")
{
    guests.Add(command);
}

while ((command = Console.ReadLine()) != "END")
{
    guests.Remove(command);
}

Console.WriteLine(guests.Count());
foreach (string guest in guests)
{
    char[] ch = guest.ToCharArray();

    if (char.IsDigit(ch[0]))
    {
        Console.WriteLine(guest);
    }
}
foreach (string guest in guests)
{
    char[] ch = guest.ToCharArray();
    if (char.IsLetter(ch[0]))
    {
        Console.WriteLine(guest);
    }
}
