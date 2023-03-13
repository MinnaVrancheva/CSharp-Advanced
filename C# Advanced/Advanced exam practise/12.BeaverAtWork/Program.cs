using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.BeaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int branchesCount = 0;
            string lastDirection;
            string[,] matrix = new string[size, size];
            int[] beaverCoordinates = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = input[column];
                    if (matrix[row, column] == "B")
                    {
                        beaverCoordinates[0] = row;
                        beaverCoordinates[1] = column;
                        matrix[row, column] = "-";
                    }
                    if (matrix[row, column].All(char.IsLower))
                    {
                        branchesCount++;
                    }
                }
            }

            
            List<string> branches = new List<string>();
            
            string command;

            while ((command = Console.ReadLine()) != "end" && branchesCount != 0)
            {
                lastDirection = command;
                matrix[beaverCoordinates[0], beaverCoordinates[1]] = "-";

                if (command == "up")
                {
                    if(!((beaverCoordinates[0] - 1) >= 0 && beaverCoordinates[0] < matrix.GetLength(0) &&
                                beaverCoordinates[1] >= 0 && beaverCoordinates[1] < matrix.GetLength(1)))
                    {
                        branches.Clear();
                        continue;
                    }
                    beaverCoordinates[0] = beaverCoordinates[0] - 1;
                }
                else if (command == "down")
                {
                    if (!(beaverCoordinates[0] >= 0 && (beaverCoordinates[0] + 1) < matrix.GetLength(0) &&
                                beaverCoordinates[1] >= 0 && beaverCoordinates[1] < matrix.GetLength(1)))
                    {
                        branches.Clear();
                        continue;
                    }
                    beaverCoordinates[0] = beaverCoordinates[0] + 1;
                }
                else if (command == "right")
                {
                    if (!(beaverCoordinates[0] >= 0 && beaverCoordinates[0] < matrix.GetLength(0) &&
                                beaverCoordinates[1] >= 0 && (beaverCoordinates[1] + 1) < matrix.GetLength(1)))
                    {
                        branches.Clear();
                        continue;
                    }
                    beaverCoordinates[1] = beaverCoordinates[1] + 1;
                }
                else if (command == "left")
                {
                    if (!(beaverCoordinates[0] >= 0 && beaverCoordinates[0] < matrix.GetLength(0) &&
                                (beaverCoordinates[1] - 1) >= 0 && beaverCoordinates[1] < matrix.GetLength(1)))
                    {
                        branches.Clear();
                        continue;
                    }
                    beaverCoordinates[1] = beaverCoordinates[1] - 1;
                }

                if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                {
                    string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                    branches.Add(item);
                    branchesCount--;
                    matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                }
                else if (matrix[beaverCoordinates[0], beaverCoordinates[1]] == "F")
                {
                    matrix[beaverCoordinates[0], beaverCoordinates[1]] = "-";

                    if (lastDirection == "up")
                    {
                        if (beaverCoordinates[0] == 0)
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[0] = matrix.GetLength(0) - 1;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                        else
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[0] = 0;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                    }
                    else if (lastDirection == "down")
                    {
                        if (beaverCoordinates[0] == matrix.GetLength(0) - 1)
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[0] = 0;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                        else
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[0] = matrix.GetLength(0) - 1;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                    }
                    else if (lastDirection == "right")
                    {
                        if (beaverCoordinates[1] == matrix.GetLength(1) - 1)
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[1] = 0;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                        else
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[1] = matrix.GetLength(1) - 1;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                    }
                    else if (lastDirection == "left")
                    {
                        if (beaverCoordinates[1] == 0)
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[1] = matrix.GetLength(1) - 1;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                        else
                        {
                            if (matrix[beaverCoordinates[0], beaverCoordinates[1]].All(char.IsLower))
                            {
                                string item = matrix[beaverCoordinates[0], beaverCoordinates[1]];
                                branches.Add(item);
                                branchesCount--;
                            }
                            beaverCoordinates[1] = 0;
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
                        }
                    }
                }
                
                    matrix[beaverCoordinates[0], beaverCoordinates[1]] = "B";
            }

            if (branchesCount == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");

            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {branchesCount} branches left.");
            }

            PrintMatrix(matrix);
        }

        
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

        
    }
}
