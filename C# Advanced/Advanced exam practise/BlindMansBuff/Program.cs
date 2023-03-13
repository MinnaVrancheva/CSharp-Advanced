
string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

string[,] matrix = new string[rows, cols];
int[] myCoordinates = new int[2];


for (int row = 0; row < rows; row++)
{
    string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input2[col];

        if (matrix[row, col] == "B")
        {
            myCoordinates[0] = row;
            myCoordinates[1] = col;
        }
    }
}

int touchedOpponents = 0;
int movesMade = 0;

string direction;

while ((direction = Console.ReadLine()) != "Finish")
{
    int[] oldCoordinates = new int [2];
    oldCoordinates [0] = myCoordinates[0];
    oldCoordinates [1] = myCoordinates[1];

    matrix[myCoordinates[0], myCoordinates[1]] = "-";
    Move(myCoordinates, direction);

    if (!(myCoordinates[0] >= 0 && myCoordinates[0] < matrix.GetLength(0) &&
                    myCoordinates[1] >= 0 && myCoordinates[1] < matrix.GetLength(1)))
    {
        myCoordinates[0] = oldCoordinates[0];
        myCoordinates[1] = oldCoordinates[1];
        matrix[myCoordinates[0], myCoordinates[1]] = "B";
    }
    else if (matrix[myCoordinates[0], myCoordinates[1]] == "O")
    {
        myCoordinates[0] = oldCoordinates[0];
        myCoordinates[1] = oldCoordinates[1];
        matrix[myCoordinates[0], myCoordinates[1]] = "B";
    }
    else if (matrix[myCoordinates[0], myCoordinates[1]] == "-")
    {
        movesMade++;
    }
    else if (matrix[myCoordinates[0], myCoordinates[1]] == "P")
    {
        movesMade++;
        touchedOpponents++;
        matrix[myCoordinates[0], myCoordinates[1]] = "B";
    }

    if (touchedOpponents == 3)
    {
        break;
    }
}

Console.WriteLine($"Game over!");
Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {movesMade}");

static void Move(int[] beeCoordiantes, string direction)
{
    switch (direction)
    {
        case "up":
            beeCoordiantes[0] -= 1;
            break;
        case "down":
            beeCoordiantes[0] += 1;
            break;
        case "left":
            beeCoordiantes[1] -= 1;
            break;
        case "right":
            beeCoordiantes[1] += 1;
            break;
    }
}


