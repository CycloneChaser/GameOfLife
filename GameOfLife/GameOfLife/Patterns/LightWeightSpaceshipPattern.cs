namespace Cfh.GameOfLife.Patterns
{
    public class LightWeightSpaceshipPattern : Pattern
    {
        public LightWeightSpaceshipPattern() :
          base(7, 50)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(2, 2, true);
            SetIsAlive(2, 3, true);
            SetIsAlive(3, 0, true);
            SetIsAlive(3, 1, true);
            SetIsAlive(3, 3, true);
            SetIsAlive(3, 4, true);
            SetIsAlive(4, 0, true);
            SetIsAlive(4, 1, true);
            SetIsAlive(4, 2, true);
            SetIsAlive(4, 3, true);
            SetIsAlive(5, 1, true);
            SetIsAlive(5, 2, true);
        }
    }
}
