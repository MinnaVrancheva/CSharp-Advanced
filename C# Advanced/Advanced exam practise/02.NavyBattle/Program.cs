
int input = int.Parse(Console.ReadLine());

char[,] battleField = new char[input, input];
int[] currentPosition = new int[2];

for (int row = 0; row < battleField.GetLength(0); row++)
{
    string input2 = Console.ReadLine();
    char[] characters = input2.ToCharArray();    

    for (int column = 0; column < battleField.GetLength(1); column++)
    {
        battleField[row, column] = characters[column];

        if (battleField[row, column] == 'S')
        {
            battleField[row, column] = '-';
            currentPosition[0] = row;
            currentPosition[1] = column;
        }
    }
}

int count = 0;
int destroyedCruisers = 0;

while (count != 3 && destroyedCruisers != 3)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "up":
            currentPosition[0] = currentPosition[0] - 1;
            break;
        case "down":
            currentPosition[0] = currentPosition[0] + 1;
            break;
        case "right":
            currentPosition[1] = currentPosition[1] + 1;
            break;
        case "left":
            currentPosition[1] = currentPosition[1] - 1;
            break;
    }

    if (battleField[currentPosition[0], currentPosition[1]] == '-')
    {
        continue;
    }
    else if (battleField[currentPosition[0], currentPosition[1]] == '*')
    {
        count++;
        battleField[currentPosition[0], currentPosition[1]] = '-';
    }
    else if (battleField[currentPosition[0], currentPosition[1]] == 'C')
    {
        destroyedCruisers++;
        battleField[currentPosition[0], currentPosition[1]] = '-';
    }
}

battleField[currentPosition[0], currentPosition[1]] = 'S';

if (count == 3)
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{currentPosition[0]}, {currentPosition[1]}]!");
}
if (destroyedCruisers == 3)
{
    Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
}

for (int i = 0; i < battleField.GetLength(0); i++)
{
    for (int j = 0; j < battleField.GetLength(1); j++)
    {
        Console.Write(battleField[i,j]);
    }
    Console.WriteLine();
}



