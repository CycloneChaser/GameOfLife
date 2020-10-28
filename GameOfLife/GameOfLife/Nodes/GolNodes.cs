namespace Cfh.GameOfLife.Nodes
{
    public class GolNodes
    {
        private GolNode[,] _nodes;
        private GolNode[,] _tempNodes;
        private int numRows;
        private int numCols;

        public GolNodes(int rows, int cols)
        {
            numRows = rows;
            numCols = cols;
            _nodes = new GolNode[numRows, numCols];
            _tempNodes = new GolNode[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    _nodes[row, col] = new GolNode();
                    _tempNodes[row, col] = new GolNode();
                }
            }
        }

        public int Rows => numRows;
        public int Columns => numCols;

        public void InitializeNodes()
        {
            for (int row = 0; row < _nodes.GetLength(0); row++)
            {
                for (int col = 0; col < _nodes.GetLength(1); col++)
                {
                    if (!IsRowIndexValid(row - 1))
                    {
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.UpperLeft);
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.UpperMiddle);
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.UpperRight);
                    }
                    else
                    {
                        if (!IsColumnIndexValid(col - 1))
                            _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.UpperLeft);
                        else
                            _nodes[row, col].AddNeighbor(_nodes[row - 1, col - 1], GolNode.NeighborLocation.UpperLeft);
                        _nodes[row, col].AddNeighbor(_nodes[row - 1, col], GolNode.NeighborLocation.UpperMiddle);
                        if (!IsColumnIndexValid(col + 1))
                            _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.UpperRight);
                        else
                            _nodes[row, col].AddNeighbor(_nodes[row - 1, col + 1], GolNode.NeighborLocation.UpperRight);
                    }

                    if (!IsColumnIndexValid(col - 1))
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.Left);
                    else
                        _nodes[row, col].AddNeighbor(_nodes[row, col - 1], GolNode.NeighborLocation.Left);
                    if (!IsColumnIndexValid(col + 1))
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.Right);
                    else
                        _nodes[row, col].AddNeighbor(_nodes[row, col + 1], GolNode.NeighborLocation.Right);

                    if (!IsRowIndexValid(row + 1))
                    {
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.LowerLeft);
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.LowerMiddle);
                        _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.LowerRight);
                    }
                    else
                    {
                        if (!IsColumnIndexValid(col - 1))
                            _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.LowerLeft);
                        else
                            _nodes[row, col].AddNeighbor(_nodes[row + 1, col - 1], GolNode.NeighborLocation.LowerLeft);
                        _nodes[row, col].AddNeighbor(_nodes[row + 1, col], GolNode.NeighborLocation.LowerMiddle);
                        if (!IsColumnIndexValid(col + 1))
                            _nodes[row, col].AddNeighbor(new GolNode(), GolNode.NeighborLocation.LowerRight);
                        else
                            _nodes[row, col].AddNeighbor(_nodes[row + 1, col + 1], GolNode.NeighborLocation.LowerRight);
                    }
                }
            }
        }

        public bool IsRowIndexValid(int rowIndex)
        {
            return rowIndex >= 0 && rowIndex < _nodes.GetLength(0);
        }

        public bool IsColumnIndexValid(int colIndex)
        {
            return colIndex >= 0 && colIndex < _nodes.GetLength(1);
        }

        public void StepNodes()
        {
            for (int row = 0; row < _nodes.GetLength(0); row++)
            {
                for (int col = 0; col < _nodes.GetLength(1); col++)
                {
                    _tempNodes[row, col].IsAlive = _nodes[row, col].GetShouldBeAlive();
                }
            }
            for (int row = 0; row < _nodes.GetLength(0); row++)
            {
                for (int col = 0; col < _nodes.GetLength(1); col++)
                {
                    _nodes[row, col].IsAlive = _tempNodes[row, col].IsAlive;
                }
            }
        }

        public bool IsAlive(int row, int col)
        {
            return _nodes[row, col].IsAlive;
        }

        public void SetIsAlive(int row, int col, bool isAlive)
        {
            _nodes[row, col].IsAlive = isAlive;
        }
    }
}

