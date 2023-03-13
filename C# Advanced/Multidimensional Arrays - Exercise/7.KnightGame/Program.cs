using System;
using System.Linq;

int squareMatrixSize = int.Parse(Console.ReadLine());
char[,] matrix = new char[squareMatrixSize, squareMatrixSize];

if (squareMatrixSize < 3)
{
    Console.WriteLine(0);
    return;
}

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    string matrixCharacters = Console.ReadLine();

    for (int cols = 0; cols < matrix.GetLength(1); cols++)
    {
        matrix[rows, cols] = matrixCharacters[cols];
    }
}

int overallCount = 0;

int mostCount = 0;

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int cols = 0; cols < matrix.GetLength(1); cols++)
    {
        if (matrix[rows, cols] == 'K')
        {
            int currentCount = FindKnights(rows, cols);

            if (mostCount < currentCount)
            {
                mostCount = currentCount;
            }
        }
    }

    if (mostCount != 0)
    {
        overallCount++;
    }
}

Console.WriteLine(overallCount);

int FindKnights(int rows, int cols)
{
    int count = 0;

    //if (matrix[rows, cols] == '0')
    //    {
    //        continue;
    //    }

        //going one left/ two down
        if (rows + 2  <= matrix.GetLength(0) - 1 && cols - 1 >= 0)
        {
            if (matrix[rows + 2, cols - 1] == 'K')
            {
                matrix[rows + 2, cols - 1] = '0';
                count++;
            }
        }
        //going one right/ two down
        if (rows + 2 <= matrix.GetLength(0) - 1 && cols + 1 <= matrix.GetLength(1) - 1)
        {
            if (matrix[rows + 2, cols + 1] == 'K')
            {
                matrix[rows + 2, cols + 1] = '0';
                count++;
            }
        }
        //going two left/ one down
        if (rows + 1 <= matrix.GetLength(0) - 1 && cols - 2 >= 0)
        {
            if (matrix[rows + 1, cols - 2] == 'K')
            {
                matrix[rows + 1, cols - 2] = '0';
                count++;
            }
        }
        //goint two right/ one down
        if (rows + 1 <= matrix.GetLength(0) - 1 && cols + 2 <= matrix.GetLength(1) - 1)
        {
            if (matrix[rows + 1, cols + 2] == 'K')
            {
                matrix[rows + 1, cols + 2] = '0';
                count++;
            }
        }
    return count;
}
