using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golay_Code
{
    internal static class Program
    {
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome_Page());
        }

        // Dll import to fix low resolution issues
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        // Function to multiply a vector by a 12x23 matrix in GF(2) (binary field)
        public static int[] MultiplyVectorByMatrix(int[] vector, int[,] matrix)
        {
            if (vector.Length != 12 || matrix.GetLength(0) != 12 || matrix.GetLength(1) != 23)
            {
                throw new ArgumentException("Vector length must be 12 and matrix dimensions must be 12x23.");
            }

            int[] result = new int[23]; // Resultant vector of length 23

            // Matrix-vector multiplication in GF(2)
            for (int j = 0; j < 23; j++) // Iterating over matrix columns
            {
                result[j] = 0; // Initialize result at each position to 0
                for (int i = 0; i < 12; i++) // Iterating over matrix rows and vector elements
                {
                    // Multiply and accumulate, then take mod 2 (binary addition)
                    result[j] = (result[j] + matrix[i, j] * vector[i]) % 2;
                }
            }

            return result;
        }

        public static int[] SimulateNoisyChannel(int[] vector, double errorProbability)
        {
            Random random = new Random();
            int[] noisyVector = new int[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                // Copy the original vector
                noisyVector[i] = vector[i];

                // Generate a random number to decide if the bit should flip
                double rand = random.NextDouble();  // Random number between 0 and 1

                if (rand <= errorProbability)
                {
                    // Flip the bit if random number is less than or equal to the error probability
                    noisyVector[i] = 1 - vector[i];  // Flip: 0 becomes 1, 1 becomes 0
                }
            }

            return noisyVector;
        }
    }
}
