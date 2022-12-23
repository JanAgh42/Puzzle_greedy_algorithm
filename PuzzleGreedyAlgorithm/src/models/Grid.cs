namespace PuzzleGreedyAlgorithm.src.models
{
    class Grid
    {
        public Card[,] CurrentCards { get; set; } = null!;
        public Card[,] FinalCards { get; set; }= null!;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void GenerateInitialCards((List<int> initial, List<int> final) grids)
        {
            
        }
    }
}