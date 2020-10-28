namespace Cfh.GameOfLife.Patterns
{
    public class BeehivePattern : Pattern
    {
        public BeehivePattern() :
          base(5, 6)
        {
            InitializePattern();
            InitializeNodes();
        }

        public void InitializePattern()
        {
            SetIsAlive(1, 2, true);
            SetIsAlive(1, 3, true);
            SetIsAlive(2, 1, true);
            SetIsAlive(2, 4, true);
            SetIsAlive(3, 2, true);
            SetIsAlive(3, 3, true);
        }
    }
}
