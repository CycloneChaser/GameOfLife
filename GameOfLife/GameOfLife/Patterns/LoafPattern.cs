namespace Cfh.GameOfLife.Patterns
{
    public class LoafPattern : Pattern
    {
        public LoafPattern() :
          base(6, 6)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(1, 2, true);
            SetIsAlive(1, 3, true);
            SetIsAlive(2, 1, true);
            SetIsAlive(2, 4, true);
            SetIsAlive(3, 2, true);
            SetIsAlive(3, 4, true);
            SetIsAlive(4, 3, true);
        }
    }
}
