using PuzzleGreedyAlgorithm.src.logic;

namespace PuzzleGreedyAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var choice = UserInterface.GetInitialInput();

                if (choice == "0") {
                    break;
                }
                var loadedGrids = InputLoader.LoadGrids(choice);

                var algorithm = new GreedyAlgorithm(loadedGrids.Item1, loadedGrids.Item2);

                Console.WriteLine("Starting grid: ");
                UserInterface.GridOutput(loadedGrids.Item1.Item1, loadedGrids.Item2.Item1);

                algorithm.PerformAlgorithm();

                Console.WriteLine("Final grid: ");
                UserInterface.GridOutput(loadedGrids.Item1.Item2, loadedGrids.Item2.Item1);
            } while (true);
        }
    }
}