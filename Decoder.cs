using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golay_Code
{
    internal static class Decoder
    {
        public static int[] Decode(int[] receivedVector, int[,] matrixH, int[,] matrixB)
        {
            int[] vectorWi = Vectors.MakeVectorHaveOddNumberOfOnes(receivedVector);
            int[] syndrome = Matrices.MultiplyVectorByMatrix(vectorWi, matrixH, matrixH.GetLength(0), matrixH.GetLength(1));
            if (Vectors.GetVectorWeight(syndrome) <= 3)
            {
                int[] errorVector = new int[syndrome.Length + 12];
                Array.Copy(syndrome, errorVector, syndrome.Length);

                int[] result = Vectors.AddBinaryVectorsMod2(vectorWi, errorVector);

                int[] decodedVector = new int[12];
                Array.Copy(result, 0, decodedVector, 0, 12);

                return decodedVector;
            }
            else
            {
                int[] errorVector = CheckMatrixBRows(matrixB, syndrome, syndrome.Length, 1);

                if (errorVector != null)
                {
                    int[] result = Vectors.AddBinaryVectorsMod2(vectorWi, errorVector);

                    int[] decodedVector = new int[12];
                    Array.Copy(result, 0, decodedVector, 0, 12);

                    return decodedVector;
                }
                else
                {
                    int[] secondSyndrome = Matrices.MultiplyVectorByMatrix(syndrome, matrixB, matrixB.GetLength(0), matrixB.GetLength(1));
                    if (Vectors.GetVectorWeight(secondSyndrome) <= 3)
                    {
                        int[] errors = new int[syndrome.Length + 12];
                        Array.Copy(syndrome, 0, errors, 12, syndrome.Length);

                        int[] result = Vectors.AddBinaryVectorsMod2(vectorWi, errors);

                        int[] decodedVector = new int[12];
                        Array.Copy(result, 0, decodedVector, 0, 12);

                        return decodedVector;
                    }
                    else
                    {
                        int[] errors = CheckMatrixBRows(matrixB, secondSyndrome, secondSyndrome.Length, 2);
                        int[] result = Vectors.AddBinaryVectorsMod2(vectorWi, errors);

                        int[] decodedVector = new int[12];
                        Array.Copy(result, 0, decodedVector, 0, 12);

                        return decodedVector;
                    }
                }
            }
        }

        public static int[] CheckMatrixBRows(int[,] matrix, int[] syndrome, int length, int syndromeNr)
        {
            for (int i = 0; i < length; i++)
            {
                int[] row = Matrices.GetRow(matrix, i);
                int[] sum = Vectors.AddBinaryVectorsMod2(row, syndrome);

                if (Vectors.GetVectorWeight(sum) <= 2)
                {
                    // Create a 12-bit vector with 1 at the ith position
                    int[] identifierVector = new int[12];
                    identifierVector[i] = 1;

                    int[] result = new int[sum.Length + identifierVector.Length];
                    if (syndromeNr == 1)
                    {
                        // Append the identifier vector to the sum
                        Array.Copy(sum, result, sum.Length);
                        Array.Copy(identifierVector, 0, result, sum.Length, identifierVector.Length);
                    }
                    if (syndromeNr == 2)
                    {
                        // Prepend the identifier vector to the start of the result
                        Array.Copy(identifierVector, 0, result, 0, identifierVector.Length);
                        Array.Copy(sum, 0, result, identifierVector.Length, sum.Length);
                    }

                    return result;
                }
            }
            // Return null if no result met the condition
            return null;
        }
    }
}
