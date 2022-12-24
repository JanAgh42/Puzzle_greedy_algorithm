namespace PuzzleGreedyAlgorithm.src.logic
{
    static class InputLoader
    {
        public static ((string, string), (int, int)) LoadGrids(string filename)
        {
            var lines = System.IO.File.ReadLines(@"./src/inputs/" + filename + ".txt").ToList();

            int chosenInput = new Random().Next(1, Convert.ToInt32(lines.First()) + 1);

            var tokens = lines[chosenInput].Split("_");
            var dims = filename.Split("x");

            var gridDimensions = (Convert.ToInt32(dims.First()), Convert.ToInt32(dims.Last()));

            return ((tokens.First(), tokens.Last()), gridDimensions);
        }
    }
}