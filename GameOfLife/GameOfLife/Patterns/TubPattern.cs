namespace Cfh.GameOfLife.Patterns
{
    public class TubPattern : Pattern
    {
        public TubPattern() :
          base(5, 5)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(1, 2, true);
            SetIsAlive(2, 1, true);
            SetIsAlive(2, 3, true);
            SetIsAlive(3, 2, true);
        }
    }
}
