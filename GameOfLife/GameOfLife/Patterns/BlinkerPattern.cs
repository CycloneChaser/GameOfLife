namespace Cfh.GameOfLife.Patterns
{
    public class BlinkerPattern : Pattern
    {
        public BlinkerPattern() :
          base(5, 5)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(2, 1, true);
            SetIsAlive(2, 2, true);
            SetIsAlive(2, 3, true);
        }
    }
}
