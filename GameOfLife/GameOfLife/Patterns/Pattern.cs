using System;
using System.Threading;
using Cfh.GameOfLife.Nodes;

namespace Cfh.GameOfLife.Patterns
{
    public class Pattern
    {
        private readonly int _rows;
        private readonly int _cols;
        private GolNodes _nodes;

        public Pattern(int rows, int columns)
        {
            _rows = rows;
            _cols = columns;
            _nodes = new GolNodes(_rows, _cols);
        }

        public int Rows => _rows;
        public int Columns => _cols;

        public bool IsAlive(int row, int col)
        {
            return _nodes.IsAlive(row, col);
        }

        public void SetIsAlive(int row, int col, bool isAlive)
        {
            if (row >= _nodes.Rows)
                throw new IndexOutOfRangeException(string.Format("Row index ({0}) is outside of range [0,{1}]", row, _nodes.Rows - 1));
            if (col >= _nodes.Columns)
                throw new IndexOutOfRangeException(string.Format("Column index ({0}) is outside of range [0,{1}]", col, _nodes.Columns - 1));
            _nodes.SetIsAlive(row, col, isAlive);
        }

        public void InitializeNodes()
        {
            _nodes.InitializeNodes();
        }

        public void StepPattern()
        {
            _nodes.StepNodes();
        }

        public void Show(int steps, int delayMS)
        {
            Console.Clear();
            Console.CursorVisible = false;
            for (int i = 0; i < steps; i++)
            {
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Columns; col++)
                    {
                        if (IsAlive(row, col))
                            Console.Write('X');
                        else
                            Console.Write(' ');
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.Write(string.Format("{0:00}", steps - i));
                Thread.Sleep(delayMS);
                StepPattern();
            }
        }
    }
}
