﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golay_Code
{
    internal static class Matrices
    {
        public static int[,] GetMatrixG()
        {
            return new int[,]
            {
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0},
                {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1},
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0},
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1},
                {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            };
        }
        public static int[,] GetMatrixB()
        {
            return new int[,]
            {
                { 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1},
                { 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1},
                { 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1},
                { 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1},
                { 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1},
                { 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1},
                { 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1},
                { 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1},
                { 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1},
                { 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1},
                { 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0}
            };
        }

        public static int[,] GetMatrixH()
        {
            return new int[,]
            {
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1},
                {1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1},
                {0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1},
                {1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1},
                {1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1},
                {1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1},
                {0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1},
                {0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1},
                {0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1},
                {1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1},
                {0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0}
            };
        }

        public static int[] MultiplyVectorByMatrix(int[] vector, int[,] matrix, int matrixRows, int matrixCollumns)
        {
            int[] result = new int[matrixCollumns];

            for (int j = 0; j < matrixCollumns; j++)
            {
                result[j] = 0;
                for (int i = 0; i < matrixRows; i++)
                {
                    result[j] = (result[j] + matrix[i, j] * vector[i]) % 2;
                }
            }
            return result;
        }

        public static int[] GetRow(int[,] matrix, int rowIndex)
        {
            int[] row = new int[matrix.GetLength(1)];
            for (int j = 0; j < row.Length; j++)
            {
                row[j] = matrix[rowIndex, j];
            }
            return row;
        }
    }
}
