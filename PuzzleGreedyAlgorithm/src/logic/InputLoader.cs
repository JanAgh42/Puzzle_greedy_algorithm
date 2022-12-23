namespace PuzzleGreedyAlgorithm.src.logic
{
    static class InputLoader
    {
        private static readonly Random _random = new Random();

        public static ((List<char>, List<char>), (int, int)) LoadGrids(string filename)
        {
            var lines = System.IO.File.ReadLines(@"./src/inputs/" + filename + ".txt").ToList();

            int chosenInput = _random.Next(1, Convert.ToInt32(lines.First()) + 1);

            var tokens = lines[chosenInput].Split("_");
            var dims = filename.Split("x");

            var initialGrid = tokens.First().Select(pos => pos).ToList();
            var finalGrid = tokens.Last().Select(pos => pos).ToList();
            var gridDimensions = (Convert.ToInt32(dims.First()), Convert.ToInt32(dims.Last()));

            return ((initialGrid, finalGrid), gridDimensions);
        }
    }
}