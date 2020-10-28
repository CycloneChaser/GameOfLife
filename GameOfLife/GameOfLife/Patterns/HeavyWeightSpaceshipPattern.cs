namespace Cfh.GameOfLife.Patterns
{
    public class HeavyWeightSpaceshipPattern : Pattern
    {
        public HeavyWeightSpaceshipPattern() :
          base(9, 50)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(3, 4, true);
            SetIsAlive(3, 5, true);
            SetIsAlive(4, 0, true);
            SetIsAlive(4, 1, true);
            SetIsAlive(4, 2, true);
            SetIsAlive(4, 3, true);
            SetIsAlive(4, 5, true);
            SetIsAlive(4, 6, true);
            SetIsAlive(5, 0, true);
            SetIsAlive(5, 1, true);
            SetIsAlive(5, 2, true);
            SetIsAlive(5, 3, true);
            SetIsAlive(5, 4, true);
            SetIsAlive(5, 5, true);
            SetIsAlive(6, 1, true);
            SetIsAlive(6, 2, true);
            SetIsAlive(6, 3, true);
            SetIsAlive(6, 4, true);
        }
    }
}
