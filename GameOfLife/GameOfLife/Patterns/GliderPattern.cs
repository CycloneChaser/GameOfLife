namespace Cfh.GameOfLife.Patterns
{
    public class GliderPattern : Pattern
    {
        public GliderPattern() :
          base(20, 20)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(0, 1, true);
            SetIsAlive(1, 2, true);
            SetIsAlive(2, 0, true);
            SetIsAlive(2, 1, true);
            SetIsAlive(2, 2, true);
        }
    }
}
