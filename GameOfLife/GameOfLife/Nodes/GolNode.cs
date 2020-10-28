namespace Cfh.GameOfLife.Nodes
{
    public class GolNode
    {
        public enum NeighborLocation
        {
            UpperLeft = 0,
            UpperMiddle,
            UpperRight,
            Left,
            Right,
            LowerLeft,
            LowerMiddle,
            LowerRight
        }

        GolNode[] _neighborNodes = new GolNode[8];

        public GolNode()
        {
            IsAlive = false;
        }

        public GolNode(bool isAlive)
        {
            IsAlive = isAlive;
        }

        public bool IsAlive;

        public void AddNeighbor(GolNode node, NeighborLocation location)
        {
            _neighborNodes[(int)location] = node;
        }

        public bool GetShouldBeAlive()
        {
            int countLiveNeighbors = NumberOfLiveNeighbors();
            if (countLiveNeighbors < 2 ||
              countLiveNeighbors > 3 ||
              (!IsAlive && countLiveNeighbors != 3))
                return false;
            return true;
        }

        public int NumberOfLiveNeighbors()
        {
            int countLiveNeighbors = 0;
            foreach (var node in _neighborNodes)
            {
                if (node.IsAlive)
                    countLiveNeighbors++;
            }
            return countLiveNeighbors;
        }
    }
}
