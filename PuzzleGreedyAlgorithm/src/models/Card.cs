namespace PuzzleGreedyAlgorithm.src.models
{
    class Card : Coordinates
    {
        public int Value { get; private set; }

        public Card((int, int) coords, int value = -1) : base(coords)
        {
            Value = value;
        }

        public void MoveCard((int xCoord, int yCoord) coords)
        {
            X += coords.xCoord;
            Y += coords.yCoord;
        }
    }
}