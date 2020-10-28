namespace Cfh.GameOfLife.Patterns
{
    public class PulsarPattern : Pattern
    {
        public PulsarPattern() :
          base(17, 17)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(2, 4, true);
            SetIsAlive(2, 5, true);
            SetIsAlive(2, 6, true);

            SetIsAlive(2, 10, true);
            SetIsAlive(2, 11, true);
            SetIsAlive(2, 12, true);

            SetIsAlive(4, 2, true);
            SetIsAlive(4, 7, true);
            SetIsAlive(4, 9, true);
            SetIsAlive(4, 14, true);
            SetIsAlive(5, 2, true);
            SetIsAlive(5, 7, true);
            SetIsAlive(5, 9, true);
            SetIsAlive(5, 14, true);
            SetIsAlive(6, 2, true);
            SetIsAlive(6, 7, true);
            SetIsAlive(6, 9, true);
            SetIsAlive(6, 14, true);

            SetIsAlive(7, 4, true);
            SetIsAlive(7, 5, true);
            SetIsAlive(7, 6, true);
            SetIsAlive(7, 10, true);
            SetIsAlive(7, 11, true);
            SetIsAlive(7, 12, true);

            SetIsAlive(9, 4, true);
            SetIsAlive(9, 5, true);
            SetIsAlive(9, 6, true);
            SetIsAlive(9, 10, true);
            SetIsAlive(9, 11, true);
            SetIsAlive(9, 12, true);

            SetIsAlive(10, 2, true);
            SetIsAlive(10, 7, true);
            SetIsAlive(10, 9, true);
            SetIsAlive(10, 14, true);
            SetIsAlive(11, 2, true);
            SetIsAlive(11, 7, true);
            SetIsAlive(11, 9, true);
            SetIsAlive(11, 14, true);
            SetIsAlive(12, 2, true);
            SetIsAlive(12, 7, true);
            SetIsAlive(12, 9, true);
            SetIsAlive(12, 14, true);

            SetIsAlive(14, 4, true);
            SetIsAlive(14, 5, true);
            SetIsAlive(14, 6, true);
            SetIsAlive(14, 10, true);
            SetIsAlive(14, 11, true);
            SetIsAlive(14, 12, true);
        }
    }
}
