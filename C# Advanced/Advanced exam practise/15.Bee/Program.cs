using System;

namespace _15.Bee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int[] beeCoordiantes = new int[2];
            ReadMatrix(matrix, beeCoordiantes);

            int flowersPolinated = 0;
            string direction;

            while ((direction = Console.ReadLine()) != "End")
            {
                matrix[beeCoordiantes[0], beeCoordiantes[1]] = '.';
                Move(beeCoordiantes, direction);

                if (!(beeCoordiantes[0] >= 0 && beeCoordiantes[0] < matrix.GetLength(0) &&
                    beeCoordiantes[1] >= 0 && beeCoordiantes[1] < matrix.GetLength(1)))
                {
                    Console.WriteLine($"The bee got lost!");
                    break;
                }
                else
                {
                    if (matrix[beeCoordiantes[0], beeCoordiantes[1]] == 'f')
                    {
                        flowersPolinated++;
                    }
                    else if (matrix[beeCoordiantes[0], beeCoordiantes[1]] == 'O')
                    {
                        matrix[beeCoordiantes[0], beeCoordiantes[1]] = '.';
                        Move(beeCoordiantes, direction);

                        if (matrix[beeCoordiantes[0], beeCoordiantes[1]] == 'f')
                        {
                            flowersPolinated++;
                        }
                    }
                }
                matrix[beeCoordiantes[0], beeCoordiantes[1]] = 'B';
            }

            if (flowersPolinated >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersPolinated} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowersPolinated} flowers more");
            }

            PrintMatrix(matrix);
        }

        private static void Move(int[] beeCoordiantes, string direction)
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

        private static void ReadMatrix(char[,] matrix, int[] beeCoordiantes)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] characters = input.ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = characters[col];

                    if (matrix[row, col] == 'B')
                    {
                        beeCoordiantes[0] = row;
                        beeCoordiantes[1] = col;
                        //matrix[row, col] = '.';
                    }
                }
            }
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
    }
}
