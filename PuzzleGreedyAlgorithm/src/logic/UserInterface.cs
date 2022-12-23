using PuzzleGreedyAlgorithm.src.models;

namespace PuzzleGreedyAlgorithm.src.logic
{
    static class UserInterface
    {
        public static string GetInitialInput()
        {
            while (true)
            {
                Console.WriteLine("Available files: 2x3, 2x4, 2x5, 3x3");
                Console.Write("Your choice (empty - exit): ");

                var userInput = Console.ReadLine();
                userInput = userInput != "" ? userInput : "0";

                switch (userInput)
                {
                    case "2x3":
                    case "2x4":
                    case "2x5":
                    case "3x3":
                    case "0":
                        return userInput;
                    default:
                        Console.WriteLine("Invalid input."); continue;
                }
            }
        }

        public static void GridOutput(Card[,] grid)
        {
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    Console.Write(grid[y, x].Value + " ");
                }
                Console.WriteLine();
            }
        }
    }
}