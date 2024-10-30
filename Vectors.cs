using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golay_Code
{
    internal static class Vectors
    {
        // Helper function to add two binary vectors mod 2
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

        // Parse input vector from string
        public static int[] ParseInputVector(string inputText)
        {
            string[] input = inputText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(input, int.Parse);
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
