using System;

namespace _13.Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] snakeCoordinates = new int[2];
            char[,] matrix = new char[size, size];
            int[] burrow1 = new int[2];
            int[] burrow2 = new int[2];
            bool burrowPassed = false;
            burrowPassed = ReadMatrix(snakeCoordinates, matrix, burrow1, burrow2, burrowPassed);

            int foodQuantity = 0;

            while (foodQuantity < 10)
            {
                string direction = Console.ReadLine();
                matrix[snakeCoordinates[0], snakeCoordinates[1]] = '.';
                Move(snakeCoordinates, direction);

                if (!(snakeCoordinates[0] >= 0 && snakeCoordinates[0] < matrix.GetLength(0) &&
                    snakeCoordinates[1] >= 0 && snakeCoordinates[1] < matrix.GetLength(1)))
                {
                    Console.WriteLine($"Game over!");
                    break;
                }
                else
                {
                    foodQuantity = ImplementCommands(snakeCoordinates, matrix, burrow1, burrow2, foodQuantity);

                    matrix[snakeCoordinates[0], snakeCoordinates[1]] = 'S';

                }
            }

            if (foodQuantity >= 10)
            {
                Console.WriteLine($"You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");
            PrintMatrix(matrix);
        }

        private static bool ReadMatrix(int[] snakeCoordinates, char[,] matrix, int[] burrow1, int[] burrow2, bool burrowPassed)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] characters = input.ToCharArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = characters[col];

                    if (matrix[row, col] == 'S')
                    {
                        snakeCoordinates[0] = row;
                        snakeCoordinates[1] = col;
                        matrix[row, col] = '-';
                    }
                    else if (matrix[row, col] == 'B')
                    {
                        if (!burrowPassed)
                        {
                            burrow2[0] = row;
                            burrow2[1] = col;
                            burrowPassed = true;
                        }
                        else
                        {
                            burrow1[0] = row;
                            burrow1[1] = col;
                        }
                    }
                }
            }

            return burrowPassed;
        }

        private static int ImplementCommands(int[] snakeCoordinates, char[,] matrix, int[] burrow1, int[] burrow2, int foodQuantity)
        {
            if (matrix[snakeCoordinates[0], snakeCoordinates[1]] == '*')
            {
                matrix[snakeCoordinates[0], snakeCoordinates[1]] = '.';
                foodQuantity++;
            }
            else if (matrix[snakeCoordinates[0], snakeCoordinates[1]] == 'B')
            {
                if (snakeCoordinates[0] == burrow1[0] && snakeCoordinates[1] == burrow1[1])
                {
                    snakeCoordinates[0] = burrow2[0];
                    snakeCoordinates[1] = burrow2[1];
                    matrix[burrow1[0], burrow1[1]] = '.';
                    matrix[burrow2[0], burrow2[1]] = '.';
                }
                else if (snakeCoordinates[0] == burrow2[0] && snakeCoordinates[1] == burrow2[1])
                {
                    snakeCoordinates[0] = burrow1[0];
                    snakeCoordinates[1] = burrow1[1];
                    matrix[burrow1[0], burrow1[1]] = '.';
                    matrix[burrow2[0], burrow2[1]] = '.';
                }
            }

            return foodQuantity;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void Move(int[] snakeCoordinates, string direction)
        {
            switch (direction)
            {
                case "up":
                    snakeCoordinates[0] -= 1;
                    break;
                case "down":
                    snakeCoordinates[0] += 1;
                    break;
                case "left":
                    snakeCoordinates[1] -= 1;
                    break;
                case "right":
                    snakeCoordinates[1] += 1;
                    break;
            }
        }
    }
}
