using PuzzleGreedyAlgorithm.src.models;

namespace PuzzleGreedyAlgorithm.src.logic
{
    class GreedyAlgorithm
    {
        public Grid PuzzleGrid { get; set; } = null!;

        public GreedyAlgorithm((List<char>, List<char>) grids, (int width, int height) dims)
        {
            PuzzleGrid = new Grid(dims.width, dims.height);

            PuzzleGrid.GenerateInitialCards(grids);
        }

        public void PerformAlgorithm()
        {
            
        }
    }
}