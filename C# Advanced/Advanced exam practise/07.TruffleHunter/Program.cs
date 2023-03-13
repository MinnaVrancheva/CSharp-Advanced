
using System.Text;

int size = int.Parse(Console.ReadLine());
string[,] matrix = new string[size, size];

SetMatrix(matrix);

int blackTrufflesCount = 0;
int whiteTrufflesCount = 0;
int summerTrufflesCount = 0;
int truffelsLost = 0;

string command;

while ((command = Console.ReadLine()) != "Stop the hunt")
{
    if (command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] == "Collect")
    {
        int row = int.Parse(command.Split()[1]);
        int col = int.Parse(command.Split()[2]);

        if (matrix [row, col] != "-")
        {
            if (matrix[row, col] == "B")
            {
                blackTrufflesCount++;
            }
            else if (matrix[row, col] == "W")
            {
                whiteTrufflesCount++;
            }
            else
            {
                summerTrufflesCount++;
            }
            matrix[row, col] = "-";
        }
    }
    else if (command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] == "Wild_Boar")
    {
        int row = int.Parse(command.Split()[1]);
        int col = int.Parse(command.Split()[2]);
        string direction = command.Split()[3];

        if (direction == "right")
        {
            for (int i = col; i < matrix.GetLength(1); i += 2)
            {
                if (matrix[row, i] == "W" || matrix[row, i] == "S" || matrix[row, i] == "B")
                {
                    truffelsLost++;
                }
                matrix[row, i] = "-";
            }
        }
        if (direction == "left")
        {
            for (int i = col; i >= 0; i -= 2)
            {
                if (matrix[row, i] == "W" || matrix[row, i] == "S" || matrix[row, i] == "B")
                {
                    truffelsLost++;
                }
                matrix[row, i] = "-";
            }
        }
        else if (direction == "up")
        {
            for (int i = row; i >= 0; i -= 2)
            {
                if (matrix[i, col] == "W" || matrix[i, col] == "S" || matrix[i, col] == "B")
                {
                    truffelsLost++;
                }
                matrix[i, col] = "-";
            }
        }
        else if (direction == "down")
        {
            for (int i = row; i < matrix.GetLength(0); i += 2)
            {
                if (matrix[i, col] == "W" || matrix[i, col] == "S" || matrix[i, col] == "B")
                {
                    truffelsLost++;
                }
                matrix[i, col] = "-";
            }
        }

    }
}

Console.WriteLine($"Peter manages to harvest {blackTrufflesCount} black, {summerTrufflesCount} summer, and {whiteTrufflesCount} white truffles.");
Console.WriteLine($"The wild boar has eaten {truffelsLost} truffles.");

PrintMatrix(matrix);



static void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(matrix[i, j]);
            sb.Append(' ');
            Console.Write(sb);
        }
        Console.WriteLine();
    }
}

static void SetMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[row, column] = input[column];
        }
    }
}