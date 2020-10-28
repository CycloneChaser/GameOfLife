using System.Collections.Generic;
using Cfh.GameOfLife.Patterns;

namespace Cfh.Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pattern> patterns = new List<Pattern>();
            patterns.Add(new BlockPattern());
            patterns.Add(new BeehivePattern());
            patterns.Add(new LoafPattern());
            patterns.Add(new BoatPattern());
            patterns.Add(new BlinkerPattern());
            patterns.Add(new ToadPattern());
            patterns.Add(new BeaconPattern());
            patterns.Add(new PulsarPattern());
            patterns.Add(new PentadecathlonPattern());
            patterns.Add(new GliderPattern());
            patterns.Add(new LightWeightSpaceshipPattern());
            patterns.Add(new MiddleWeightSpaceshipPattern());
            patterns.Add(new HeavyWeightSpaceshipPattern());
            foreach (var pattern in patterns)
                pattern.Show(35, 150);
        }
    }
}
