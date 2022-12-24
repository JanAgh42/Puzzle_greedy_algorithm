using System.Text;

namespace PuzzleGreedyAlgorithm.src.logic
{
    static class Misc
    {
        public static List<(string, char)> GetNewConfigs(string config, char prev, int width)
        {
            var potentionalConfigs = new List<(string, char)>();
            var potentialMoves = new List<int>();

            int empty = config.IndexOf('n');
            int previous = config.IndexOf(prev);

            int moveUp = empty - width;
            int moveDown = empty + width;
            int moveLeft = empty - 1;
            int moveRight = empty + 1;

            if (moveUp != previous && moveUp >= 0) {
                potentialMoves.Add(moveUp);
            }
            if (moveDown != previous && moveDown < config.Length) {
                potentialMoves.Add(moveDown);
            }
            if (moveLeft != previous && moveLeft >= 0 && moveLeft % width != width - 1) {
                potentialMoves.Add(moveLeft);
            }
            if (moveRight != previous && moveRight < config.Length && moveRight % width != 0) {
                potentialMoves.Add(moveRight);
            }

            foreach (var move in potentialMoves)
            {
                StringBuilder newConfig = new StringBuilder(config);

                newConfig[empty] = config[move];
                newConfig[move] = config[empty];

                potentionalConfigs.Add((newConfig.ToString(), newConfig[empty]));
            }
            return potentionalConfigs;
        }
    }
}