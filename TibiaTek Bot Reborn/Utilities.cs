using System;

namespace TibiaTekBot
{
    public static class Utilities
    {
        public static ulong ConvertLevelToExperience(uint level)
        {
            double first_stage = (16.0 + (2.0 / 3.0)) * Math.Pow((double)level, 3);
            double second_stage = 100.0 * Math.Pow((double)level, 2);
            double third_stage = ((283 + (1.0 / 3.0)) * (double)level) - 200;
            return (ulong) Math.Floor(first_stage - second_stage + third_stage);
        }
    }
}
