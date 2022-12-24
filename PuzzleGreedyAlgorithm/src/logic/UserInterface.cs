namespace PuzzleGreedyAlgorithm.src.logic
{
    static class UserInterface
    {
        public static string GetInitialInput()
        {
            while (true)
            {
                Console.WriteLine("Available files: 3x2, 4x2, 5x2, 3x3");
                Console.Write("Your choice (empty - exit): ");

                var userInput = Console.ReadLine();
                userInput = userInput != "" ? userInput : "0";

                switch (userInput)
                {
                    case "3x2":
                    case "4x2":
                    case "5x2":
                    case "3x3":
                    case "0":
                        return userInput;
                    default:
                        Console.WriteLine("Invalid input."); continue;
                }
            }
        }

        public static void GridOutput(string grid, int width)
        {
            for (int y = 0; y < grid.Length / width; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(grid[y * width + x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}