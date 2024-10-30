using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golay_Code
{
    internal static class Encoder
    {
        public static int[] Encode(int[] vector, int[,] matrix)
        {
            return Matrices.MultiplyVectorByMatrix(vector, matrix, matrix.GetLength(0), matrix.GetLength(1));
        }
    }
}
