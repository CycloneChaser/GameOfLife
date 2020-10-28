namespace Cfh.GameOfLife.Patterns
{
    public class ToadPattern : Pattern
    {
        public ToadPattern() :
          base(6, 6)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(2, 2, true);
            SetIsAlive(2, 3, true);
            SetIsAlive(2, 4, true);
            SetIsAlive(3, 1, true);
            SetIsAlive(3, 2, true);
            SetIsAlive(3, 3, true);
        }
    }
}
