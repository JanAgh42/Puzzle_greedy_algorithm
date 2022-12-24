namespace PuzzleGreedyAlgorithm.src.logic
{
    class GreedyAlgorithm
    {
        public List<((string, char), int)> AllConfigs { get; set; } = null!;
        public List<((string, char), int)> NotExpConfigs { get; set; } = null!;

        public int Width { get; private set; }
        public int Height { get; private set; }

        private (string value, int distance) _currentConfig = ("", -1);
        private string _finalConfig = "";
        private char _previouslyMoved = 'n';
        private int _configCounter = 1;

        public GreedyAlgorithm((string, string) grids, (int width, int height) dims)
        {
            Width = dims.width;
            Height = dims.height;
            _finalConfig = grids.Item2;

            AllConfigs = new List<((string, char), int)>();
            NotExpConfigs = new List<((string, char), int)>();

            AllConfigs.Add(((grids.Item1, _previouslyMoved), ComputeDistance(grids.Item1)));
            NotExpConfigs.Add(((grids.Item1, _previouslyMoved), ComputeDistance(grids.Item1)));
        }

        public void PerformAlgorithm()
        {
            while (true)
            {
                if (_currentConfig.distance == 0) {
                    break;
                }
                var uniqueConfigs = new List<((string, char), int)>();

                foreach (var config in Misc.GetNewConfigs(_currentConfig.value, _previouslyMoved, Width))
                {
                    var distance = ComputeDistance(config.Item1);

                    if (AllConfigs.Contains((config, distance))) {
                        continue;
                    }
                    uniqueConfigs.Add((config, distance));
                    AllConfigs.Add((config, distance));
                }
                uniqueConfigs.Sort((x, y) => y.Item2.CompareTo(x.Item2));
                uniqueConfigs.Reverse();

                if (uniqueConfigs.Count() > 0) {
                    _currentConfig = (uniqueConfigs[0].Item1.Item1, uniqueConfigs[0].Item2);
                    _previouslyMoved = uniqueConfigs[0].Item1.Item2;

                    uniqueConfigs.RemoveAt(0);
                    uniqueConfigs.ForEach(config => NotExpConfigs.Add(config));

                    NotExpConfigs.Sort((x, y) => y.Item2.CompareTo(x.Item2));
                    NotExpConfigs.Reverse();
                }
                else if (NotExpConfigs.Count() > 0) {
                    _currentConfig = (NotExpConfigs[0].Item1.Item1, NotExpConfigs[0].Item2);
                    _previouslyMoved = NotExpConfigs[0].Item1.Item2;

                    NotExpConfigs.RemoveAt(0);
                }
                else {
                    Console.WriteLine("Solution does not exist."); return;
                }
                Console.WriteLine($"{_configCounter++}. grid: {_currentConfig.value}");
            }
            Console.WriteLine("\nFound grid: ");
            UserInterface.GridOutput(_currentConfig.value, Width);
        }

        private int ComputeDistance(string potentialConfig)
        {
            int distances = 0;

            for (int x = 0; x < _finalConfig.Length; x++)
            {
                if (potentialConfig[x] == 'n') {
                    continue;
                }

                for (int y = 0; y < _finalConfig.Length; y++)
                {
                    if (_finalConfig[y] == 'n') {
                        continue;
                    }
                    if (potentialConfig[x] == _finalConfig[y]) {
                        distances += Math.Abs(x % Width - y % Width) + Math.Abs(x / Width - y / Width);
                    }
                }
            }
            return distances;
        }
    }
}