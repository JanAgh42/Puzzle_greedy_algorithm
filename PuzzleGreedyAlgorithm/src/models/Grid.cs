using PuzzleGreedyAlgorithm.src.logic;

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

        public void GenerateInitialCards((List<char> initial, List<char> final) grids)
        {
            CurrentCards = new Card[Height, Width];
            FinalCards = new Card[Height, Width];

            for (int counterY = 0; counterY < Height; counterY++)
            {
                for (int counterX = 0; counterX < Width; counterX++)
                {
                    char initValue = grids.initial[counterY * Width + counterX];
                    char finalValue = grids.final[counterY * Width + counterX];

                    CurrentCards[counterY, counterX] = new Card((counterX, counterY), initValue);
                    FinalCards[counterY, counterX] = new Card((counterX, counterY), finalValue);
                }
            }
            CardsConsoleOutput();
        }

        private void CardsConsoleOutput()
        {
            Console.WriteLine("Initial cards position:");
            UserInterface.GridOutput(CurrentCards);

            Console.WriteLine("Final cards position:");
            UserInterface.GridOutput(FinalCards);
        }
    }
}