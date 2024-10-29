using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golay_Code
{
    public partial class Page3 : Form
    {
        public Page3(int[] receivedVector, int[] sentVector, int[] inputVector)
        {
            InitializeComponent();

            string sentVectorString = string.Join(" ", sentVector);

            LabelSent.Text = sentVectorString;

            string receivedVectorString = string.Join(" ", receivedVector);

            TextBoxReceived.Text = receivedVectorString;

            int[] errorPositions = CheckErrorPossitions(sentVectorString, receivedVectorString);

            int numberOfErrors = errorPositions.Length;
            string errorPositionsString = string.Join(", ", errorPositions);

            LabelErrorPositions.Text = errorPositionsString;
            LabelErrors.Text = numberOfErrors.ToString();


            string inputVectorString = string.Join(" ", inputVector);
            LabelInput.Text = inputVectorString;

            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private static int[] CheckErrorPossitions(string sentVector, string receivedVector) 
        {
            List<int> mismatchPositions = new List<int>();

            for (int i = 0; i < sentVector.Length; i++)
            {
                if (sentVector[i] != receivedVector[i])
                {
                    mismatchPositions.Add((i/2)+1);
                }
            }
            return mismatchPositions.ToArray();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            string sentVector = LabelSent.Text;
            string receveidVector = TextBoxReceived.Text;

            int[] errorPositions = CheckErrorPossitions(sentVector, receveidVector);

            int numberOfErrors = errorPositions.Length;
            string errorPositionsString = string.Join(", ", errorPositions);

            LabelErrorPositions.Text = errorPositionsString;
            LabelErrors.Text = numberOfErrors.ToString();
        }

        public int[] MakeVectorHaveOddNumberOfOnes(int[] receivedVector) 
        {
            int[] vector = new int[receivedVector.Length + 1];
            Array.Copy(receivedVector, vector, receivedVector.Length);

            // Adding 1 or 0 at the end, to make the received vector contain odd number of '1's
            if (HasEvenNumberOfOnes(receivedVector) == true)
            {
                vector[receivedVector.Length] = 1;
            }
            else
            {
                
                //vector[receivedVector.Length] = 0;
                vector[receivedVector.Length] = 0;
            }

            return vector;
        }

        public bool HasEvenNumberOfOnes(int[] vector)
        {
            int count = 0;

            foreach (int bit in vector)
            {
                if (bit == 1)
                {
                    count++;
                }
            }

            // Check if count is even
            return count % 2 == 0;
        }

        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            int[,] matrixH = new int[24, 12]
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

            int[,] matrixB = 
            {
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

            string receveidVectorString = TextBoxReceived.Text;
            int[] receivedVector = receveidVectorString.Split(' ').Select(int.Parse).ToArray();

            int[] vectorWi = MakeVectorHaveOddNumberOfOnes(receivedVector);

            int[] syndrome = Program.MultiplyVectorByMatrix(vectorWi, matrixH, matrixH.GetLength(0), matrixH.GetLength(1));

            if(GetVectorWeight(syndrome) <= 3)
            {
                int[] errorVector = new int[syndrome.Length + 12];
                Array.Copy(syndrome, errorVector, syndrome.Length);

                int[] result = AddBinaryVectorsMod2(vectorWi, errorVector);

                int[] decodedVector = new int[12];
                Array.Copy(result, 0, decodedVector, 0, 12);

                string decodedVectorString = string.Join(" ", decodedVector);
                LabelDecoded.Text = decodedVectorString;
            }
            else
            {
                int[] errorVector = CheckMatrixBRows(matrixB, syndrome, syndrome.Length, 1);

                if(errorVector != null)
                {
                    int[] result = AddBinaryVectorsMod2(vectorWi, errorVector);
                    
                    int[] decodedVector = new int[12];
                    Array.Copy(result, 0, decodedVector, 0, 12);

                    string decodedVectorString = string.Join(" ", decodedVector);
                    LabelDecoded.Text = decodedVectorString;
                }
                else
                {
                    int[] secondSyndrome = Program.MultiplyVectorByMatrix(syndrome, matrixB, matrixB.GetLength(0), matrixB.GetLength(1));

                    if(GetVectorWeight(secondSyndrome) <= 3)
                    {
                        int[] errors = new int[syndrome.Length + 12];
                        Array.Copy(syndrome, 0, errors, 12, syndrome.Length);

                        int[] result = AddBinaryVectorsMod2(vectorWi, errors);

                        int[] decodedVector = new int[12];
                        Array.Copy(result, 0, decodedVector, 0, 12);

                        string decodedVectorString = string.Join(" ", decodedVector);
                        LabelDecoded.Text = decodedVectorString;
                    }
                    else 
                    {
                        int[] errors = CheckMatrixBRows(matrixB, secondSyndrome, secondSyndrome.Length, 2);
                        int[] result = AddBinaryVectorsMod2(vectorWi, errors);
                        
                        int[] decodedVector = new int[12];
                        Array.Copy(result, 0, decodedVector, 0, 12);

                        string decodedVectorString = string.Join(" ", decodedVector);
                        LabelDecoded.Text = decodedVectorString;
                    }
                }
            }
        }

        public int[] CheckMatrixBRows(int[,] matrix, int[] syndrome, int length, int syndromeNr)
        {
            for (int i = 0; i < length; i++)
            {
                int[] row = GetRow(matrix, i);  // Get the row as an array
                int[] sum = AddBinaryVectorsMod2(row, syndrome);

                // Check if the Hamming weight of the result is less than or equal to 2
                if (GetVectorWeight(sum) <= 2)
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
                    if(syndromeNr == 2)
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

        // Helper function to get a row from a 2D array as a 1D array
        public int[] GetRow(int[,] matrix, int rowIndex)
        {
            int[] row = new int[matrix.GetLength(1)];
            for (int j = 0; j < row.Length; j++)
            {
                row[j] = matrix[rowIndex, j];
            }
            return row;
        }

        // Helper function to add two binary vectors mod 2
        public int[] AddBinaryVectorsMod2(int[] vectorA, int[] vectorB)
        {
            int[] result = new int[vectorA.Length];
            for (int i = 0; i < vectorA.Length; i++)
            {
                result[i] = (vectorA[i] + vectorB[i]) % 2;
            }
            return result;
        }

        public int GetVectorWeight(int[] binaryArray)
        {
            int count = 0;

            foreach (int bit in binaryArray)
            {
                if (bit == 1)
                {
                    count++;
                }
            }

            return count;
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
