namespace Cfh.GameOfLife.Patterns
{
    public class BeaconPattern : Pattern
    {
        public BeaconPattern() :
          base(6, 6)
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
            SetIsAlive(3, 3, true);
            SetIsAlive(3, 4, true);
            SetIsAlive(4, 3, true);
            SetIsAlive(4, 4, true);
        }
    }
}
