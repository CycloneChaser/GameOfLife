namespace Cfh.GameOfLife.Patterns
{
    public class BlockPattern : Pattern
    {
        public BlockPattern() :
          base(4, 4)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(1, 1, true);
            SetIsAlive(1, 2, true);
            SetIsAlive(2, 1, true);
            SetIsAlive(2, 2, true);
        }
    }
}
