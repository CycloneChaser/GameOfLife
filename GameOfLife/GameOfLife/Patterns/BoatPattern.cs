namespace Cfh.GameOfLife.Patterns
{
    public class BoatPattern : Pattern
    {
        public BoatPattern() :
          base(5, 5)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(1, 1, true);
            SetIsAlive(1, 2, true);
            SetIsAlive(2, 1, true);
            SetIsAlive(2, 3, true);
            SetIsAlive(3, 2, true);
        }
    }
}
