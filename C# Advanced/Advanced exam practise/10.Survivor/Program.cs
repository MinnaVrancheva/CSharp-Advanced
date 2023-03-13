using System;

namespace _10.Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfrows = int.Parse(Console.ReadLine());
            string[][] playGround = new string[numberOfrows][];
            ReadJaggedArray(numberOfrows, playGround);

            int tokensCount = 0;
            int tokensStolen = 0;
            string command;
            while ((command = Console.ReadLine()) != "Gong")
            {
                string command1 = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];

                if (command1 == "Find")
                {
                    int row = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    int col = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (row < 0 || col < 0 || row >= playGround.Length || col >= playGround[row].Length)
                    {
                        continue;
                    }

                    if (playGround[row][col] == "T")
                    {
                        tokensCount++;
                        playGround[row][col] = "-";
                    }
                }
                else if (command1 == "Opponent")
                {
                    int row = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    int col = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                    string direction = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[3];

                    if (row < 0 || col < 0 || row >= playGround.Length || col >= playGround[row].Length)
                    {
                        continue;
                    }

                    if (playGround[row][col] == "T")
                    {
                        tokensStolen++;
                        playGround[row][col] = "-";
                    }

                    switch (direction)
                    {
                        case "up":
                            for (int i = 1; i <= 3; i++)
                            {
                                if (row - i >= 0 && col < playGround[row - 1].Length)
                                {
                                    if (playGround[row - i][col] == "T")
                                    {
                                        playGround[row - i][col] = "-";
                                        tokensStolen++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        case "down":
                            for (int i = 1; i <= 3; i++)
                            {
                                if (row + i < playGround.Length && col < playGround[row + 1].Length)
                                {
                                    if (playGround[row + i][col] == "T")
                                    {
                                        playGround[row + i][col] = "-";
                                        tokensStolen++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        case "left":
                            for (int i = 1; i <= 3; i++)
                            {
                                if (col - i >= 0)
                                {
                                    if (playGround[row][col - i] == "T")
                                    {
                                        playGround[row][col - 1] = "-";
                                        tokensStolen++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        case "right":
                            for (int i = 1; i <= 3; i++)
                            {
                                if (col + i < playGround[row].Length)
                                {
                                    if (playGround[row][col + i] == "T")
                                    {
                                        playGround[row][col + 1] = "-";
                                        tokensStolen++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                    }

                }
            }

            foreach (string[] row in playGround)
            {
                Console.WriteLine(String.Join(" ", row));
            }

            Console.WriteLine($"Collected tokens: {tokensCount}");
            Console.WriteLine($"Opponent's tokens: {tokensStolen}");
        }

        private static void ReadJaggedArray(int numberOfrows, string[][] playGround)
        {
            for (int i = 0; i < numberOfrows; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                playGround[i] = new string[input.Length];

                for (int j = 0; j < playGround[i].Length; j++)
                {
                    playGround[i][j] = input[j];
                }
            }
        }
    }
}
