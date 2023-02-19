using System;


namespace Extensions
{
    static class RandomExtensions
    {
        public static double Next(this Random random, double min, double max)
        {
            double sample = random.NextDouble();

            return (sample*max) + (sample *( 1 -min));
        }
    }
}
