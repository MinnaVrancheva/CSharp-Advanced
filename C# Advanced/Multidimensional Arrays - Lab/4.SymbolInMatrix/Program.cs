using System;

int matrixSize = int.Parse(Console.ReadLine());

char[,] matrix = new char[matrixSize, matrixSize];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string symbols = Console.ReadLine();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        char currentSymbol = symbols[col];
        matrix[row, col] = currentSymbol;
    }
}

char symbol = char.Parse(Console.ReadLine());
bool isMatchingSymbol = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == symbol)
        {
            isMatchingSymbol = true;
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}

if(!isMatchingSymbol)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}
