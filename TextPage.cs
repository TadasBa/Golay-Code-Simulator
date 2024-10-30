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
    public partial class TextPage : Form
    {
        public TextPage()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSendTextInput_Click(object sender, EventArgs e)
        {
            string input = TextBoxTextInput.Text;

            // Convert the text to bytes
            byte[] bytes = Encoding.UTF8.GetBytes(input);

            // Calculate the length of the bit array (8 bits per byte)
            int[] bitArray = new int[bytes.Length * 8];

            // Convert each byte to bits and store in the int[] array
            int bitIndex = 0;
            foreach (byte b in bytes)
            {
                for (int i = 7; i >= 0; i--)
                {
                    // Extract each bit (0 or 1) and store in the bit array
                    bitArray[bitIndex++] = (b >> i) & 1;
                }
            }
            
            int neddedBits = 12 - bitArray.Length % 12;

            int[] textConvertedToBits = new int[bitArray.Length + neddedBits];
            Array.Copy(bitArray, textConvertedToBits, bitArray.Length);


            TextBoxWithEncoding.Text = string.Join(" ", textConvertedToBits);

            List<int[]> vectors = SplitBitArray(textConvertedToBits);

            // Display the vectors
            foreach (var vector in vectors)
            {
                //Page1.EncodeVector(vector, Page1.matrix);
            }
        }

        public static List<int[]> SplitBitArray(int[] bitArray)
        {
            int vectorLength = 12;
            List<int[]> vectors = new List<int[]>();

            // Calculate the number of complete vectors of length vectorLength
            int totalVectors = bitArray.Length / vectorLength;

            for (int i = 0; i < totalVectors; i++)
            {
                // Create a new vector of length vectorLength
                int[] vector = new int[vectorLength];

                // Copy the relevant segment from the bitArray to the vector
                Array.Copy(bitArray, i * vectorLength, vector, 0, vectorLength);

                // Add the vector to the list of vectors
                vectors.Add(vector);
            }

            return vectors;
        }


    }
}
