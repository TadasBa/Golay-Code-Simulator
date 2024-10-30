using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golay_Code
{
    internal static class Vectors
    {
        public static int[] AddBinaryVectorsMod2(int[] vectorA, int[] vectorB)
        {
            int[] result = new int[vectorA.Length];
            for (int i = 0; i < vectorA.Length; i++)
            {
                result[i] = (vectorA[i] + vectorB[i]) % 2;
            }
            return result;
        }

        public static int GetVectorWeight(int[] binaryArray)
        {
            int count = 0;
            foreach (int bit in binaryArray)
            {
                if (bit == 1)
                    count++;
            }
            return count;
        }

        public static int[] ParseInputVector(string inputText)
        {
            // Remove all spaces and commas from the input to handle continuous strings
            string sanitizedInput = inputText.Replace(" ", "").Replace(",", "");

            // Ensure the input is of length 12 and only contains binary characters (0 or 1)
            if (sanitizedInput.Length != 12 || !sanitizedInput.All(c => c == '0' || c == '1'))
            {
                throw new ArgumentException("Input must be a 12-character binary vector.");
            }

            // Convert the sanitized string to an integer array
            return sanitizedInput.Select(c => int.Parse(c.ToString())).ToArray();
        }


        public static int[] MakeVectorHaveOddNumberOfOnes(int[] receivedVector)
        {
            int[] vector = new int[receivedVector.Length + 1];
            Array.Copy(receivedVector, vector, receivedVector.Length);
            vector[receivedVector.Length] = HasEvenNumberOfOnes(receivedVector) ? 1 : 0;
            return vector;
        }
        private static bool HasEvenNumberOfOnes(int[] vector) => vector.Count(bit => bit == 1) % 2 == 0;

        public static int[] CheckErrorPositions(int[] sentVector, int[] receivedVector)
        {
            List<int> mismatchPositions = new List<int>();
            for (int i = 0; i < sentVector.Length; i++)
            {
                if (sentVector[i] != receivedVector[i])
                {
                    mismatchPositions.Add(i + 1); // Adjusting to 1-based index
                }
            }
            return mismatchPositions.ToArray();
        }

    }
}
