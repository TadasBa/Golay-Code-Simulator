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
