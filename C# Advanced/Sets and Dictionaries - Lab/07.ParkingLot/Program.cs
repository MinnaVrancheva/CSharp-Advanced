HashSet<string> carNumberPlates = new HashSet<string>();
string command;

while((command = Console.ReadLine()) != "END")
{
    string direction = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
    string carNumber = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];

    switch (direction)
    {
        case "IN":
            carNumberPlates.Add(carNumber);
            break;
        case "OUT":
            carNumberPlates.Remove(carNumber);
            break;
    }
}

if (carNumberPlates.Count > 0)
{
    foreach (string carNumber in carNumberPlates)
    {
        Console.WriteLine(carNumber);
    }
}
else
{
    Console.WriteLine($"Parking Lot is Empty");
}
