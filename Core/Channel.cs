using System;

namespace Golay_Code
{
    internal static class Channel
    {
        private static readonly Random random = new Random();

        public static int[] SimulateNoisyChannel(int[] vector, double errorProbability)
        {
            int[] noisyVector = new int[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                noisyVector[i] = vector[i];
                double rand = random.NextDouble();

                if (rand <= errorProbability)
                {
                    noisyVector[i] = 1 - vector[i];
                }
            }
            return noisyVector;
        }

        public static double ParseProbability(string probabilityText)
        {
            probabilityText = probabilityText.Replace(",", ".");

            // Convert to double and validate that it's within 0 and 1
            double probability = Convert.ToDouble(probabilityText);
            if (probability < 0 || probability > 1)
                throw new FormatException("Probability must be between 0 and 1.");

            return probability;
        }

    }
}
