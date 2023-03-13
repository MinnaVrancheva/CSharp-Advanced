
int size = int.Parse(Console.ReadLine());
int raceCarNumber = int.Parse(Console.ReadLine());

string[,] raceTrack = new string [size, size];


for (int row = 0; row < raceTrack.GetLength(0); row++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    
    for (int col = 0; col < raceTrack.GetLength(1); col++)
    {
        raceTrack[row, col] = input[col];
    }
}

int[] currentPosition = new int[2];
int totalKm = 0;
string command;
bool hasFinished = false;

while ((command = Console.ReadLine()) != "End")
{
    switch (command)
    {
        case "left":
            currentPosition[1] = currentPosition[1] - 1;
            break;
        case "right":
            currentPosition[1] = currentPosition[1] + 1;
            break;
        case "up":
            currentPosition[0] = currentPosition[0] - 1;
            break;
        case "down":
            currentPosition[0] = currentPosition[0] + 1;
            break;
    }

    if (raceTrack[currentPosition[0], currentPosition[1]] == ".")
    {
        totalKm += 10;
    }
    if (raceTrack[currentPosition[0], currentPosition[1]] == "T")
    {
        totalKm += 30;
        raceTrack[currentPosition[0], currentPosition[1]] = ".";

        bool tunnelPassed = false;
        for (int row = 0; row < raceTrack.GetLength(0); row++)
        {
            for (int col = 0; col < raceTrack.GetLength(1); col++)
            {
                if (raceTrack[row, col] == "T")
                {
                    raceTrack[row, col] = ".";
                    currentPosition[0] = row;
                    currentPosition[1] = col;
                    tunnelPassed = true;
                    break;
                }
                
            }
            if (tunnelPassed)
            {
                break;
            }
        }
    }
    if (raceTrack[currentPosition[0], currentPosition[1]] == "F")
    {
        hasFinished = true;
        totalKm += 10;
        Console.WriteLine($"Racing car {raceCarNumber} finished the stage!");
        Console.WriteLine($"Distance covered {totalKm} km.");
        break;
    }
}

if (!hasFinished)
{
    Console.WriteLine($"Racing car {raceCarNumber} DNF.");
    Console.WriteLine($"Distance covered {totalKm} km.");
}

raceTrack[currentPosition[0], currentPosition[1]] = "C";

for (int i = 0; i < raceTrack.GetLength(0); i++)
{
    for (int j = 0; j < raceTrack.GetLength(1); j++)
    {
        Console.Write(raceTrack[i, j]);
    }
    Console.WriteLine();
}

