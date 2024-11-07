using System;
using System.Collections.Generic;
using System.Text;
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

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string input = TextBoxInput.Text;

            // Step 1: Convert text to bits
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            int[] bitArray = new int[bytes.Length * 8];
            int bitIndex = 0;
            foreach (byte b in bytes)
            {
                for (int i = 7; i >= 0; i--)
                {
                    bitArray[bitIndex++] = (b >> i) & 1;
                }
            }

            // Step 2: Pad the bit array to make its length a multiple of 12
            int neededBits = 12 - (bitArray.Length % 12);
            int[] paddedBitArray = new int[bitArray.Length + neededBits];
            Array.Copy(bitArray, paddedBitArray, bitArray.Length);

            // Step 3: Split padded bit array into 12-bit vectors
            List<int[]> vectors = SplitBitArray(paddedBitArray);

            // Step 4: Encode and send each vector through the channel

            double errorProbability = Channel.ParseProbability(TextBoxProbability.Text);

            List<int> encodedAndDecodedBits = new List<int>();
            List<int> noisyUnencodedBits = new List<int>();

            foreach (var vector in vectors)
            {
                // Encode, send through channel, and decode
                int[] encodedVector = Encoder.Encode(vector, Matrices.GetMatrixG());
                int[] noisyEncodedVector = Channel.SimulateNoisyChannel(encodedVector, errorProbability);
                int[] decodedVector = Decoder.Decode(noisyEncodedVector, Matrices.GetMatrixH(), Matrices.GetMatrixB());
                encodedAndDecodedBits.AddRange(decodedVector);

                // Send original (unencoded) vector through channel
                int[] noisyUnencodedVector = Channel.SimulateNoisyChannel(vector, errorProbability);
                noisyUnencodedBits.AddRange(noisyUnencodedVector);
            }

            // Step 5: Convert the resulting noisy unencoded bit sequence back to text
            int[] noisyUnencodedBitArray = noisyUnencodedBits.ToArray();
            string decodedTextWithoutEncoding = ConvertBitsToText(noisyUnencodedBitArray, neededBits);

            // Step 6: Convert the corrected bit sequence back to text
            int[] correctedBitArray = encodedAndDecodedBits.ToArray();
            string decodedTextWithEncoding = ConvertBitsToText(correctedBitArray, neededBits);

            // Step 7: Display results
            TextBoxWithEncoding.Text = decodedTextWithEncoding;
            TextBoxWithoutEncoding.Text = decodedTextWithoutEncoding;
        }


        private string ConvertBitsToText(int[] bitArray, int paddingBits)
        {
            // Remove padding bits
            int validLength = bitArray.Length - paddingBits;
            List<byte> bytes = new List<byte>();

            // Convert every 8 bits back into a byte
            for (int i = 0; i < validLength; i += 8)
            {
                int byteValue = 0;
                for (int j = 0; j < 8; j++)
                {
                    byteValue = (byteValue << 1) | bitArray[i + j];
                }
                bytes.Add((byte)byteValue);
            }

            return Encoding.UTF8.GetString(bytes.ToArray());
        }

        public static List<int[]> SplitBitArray(int[] bitArray)
        {
            int vectorLength = 12;
            List<int[]> vectors = new List<int[]>();

            int totalVectors = bitArray.Length / vectorLength;
            for (int i = 0; i < totalVectors; i++)
            {
                int[] vector = new int[vectorLength];
                Array.Copy(bitArray, i * vectorLength, vector, 0, vectorLength);
                vectors.Add(vector);
            }

            return vectors;
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            HomePage welcomePage = new HomePage();
            welcomePage.Show();
            this.Hide();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
