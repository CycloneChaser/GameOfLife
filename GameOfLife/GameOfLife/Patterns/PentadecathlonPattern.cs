namespace Cfh.GameOfLife.Patterns
{
    public class PentadecathlonPattern : Pattern
    {
        public PentadecathlonPattern() :
          base(18, 11)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(5, 5, true);
            SetIsAlive(6, 5, true);
            SetIsAlive(7, 4, true);
            SetIsAlive(7, 6, true);
            SetIsAlive(8, 5, true);
            SetIsAlive(9, 5, true);
            SetIsAlive(10, 5, true);
            SetIsAlive(11, 5, true);
            SetIsAlive(12, 4, true);
            SetIsAlive(12, 6, true);
            SetIsAlive(13, 5, true);
            SetIsAlive(14, 5, true);
        }
    }
}
