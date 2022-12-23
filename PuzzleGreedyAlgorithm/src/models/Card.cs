namespace PuzzleGreedyAlgorithm.src.models
{
    class Card : Coordinates
    {
        public char Value { get; private set; }

        public Card((int, int) coords, char value = 'n') : base(coords)
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