using PuzzleGreedyAlgorithm.src.logic;

namespace PuzzleGreedyAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = InputLoader.LoadGrids("3x3");

            Console.WriteLine(inputs.Item1[1] + " " + inputs.Item2[1]);
        }
    }
}