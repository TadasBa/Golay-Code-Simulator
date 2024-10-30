using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golay_Code
{
    internal static class Channel
    {
        // Initialize Random only once for precision
        private static readonly Random random = new Random();

        public static int[] SimulateNoisyChannel(int[] vector, double errorProbability)
        {
            int[] noisyVector = new int[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                // Copy the original vector
                noisyVector[i] = vector[i];

                // Generate a random number to decide if the bit/symbol should be distorted
                double rand = random.NextDouble();

                if (rand <= errorProbability)
                {
                    noisyVector[i] = 1 - vector[i];
                }
            }
            return noisyVector;
        }

        // Parse and validate probability input
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
