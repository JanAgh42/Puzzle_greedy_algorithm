namespace PuzzleGreedyAlgorithm.src.logic
{
    static class InputLoader
    {
        private static readonly Random _random = new Random();

        public static ((List<int>, List<int>), (int, int)) LoadGrids(string filename)
        {
            var lines = System.IO.File.ReadLines(@"./src/inputs/" + filename + ".txt").ToList();

            int chosenInput = _random.Next(1, Convert.ToInt32(lines.First()) + 1);

            var tokens = lines[chosenInput].Split("_");
            var dims = filename.Split("x");

            var initialGrid = tokens.First().Select(pos => Convert.ToInt32(pos.ToString())).ToList();
            var finalGrid = tokens.Last().Select(pos => Convert.ToInt32(pos.ToString())).ToList();
            var gridDimensions = (Convert.ToInt32(dims.First()), Convert.ToInt32(dims.Last()));

            return ((initialGrid, finalGrid), gridDimensions);
        }
    }
}