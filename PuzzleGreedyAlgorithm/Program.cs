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

            } while (true);
        }
    }
}