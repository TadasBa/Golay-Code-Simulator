using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Golay_Code
{
    public partial class ImagePage : Form
    {
        private Bitmap originalImage;

        public ImagePage()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        originalImage = new Bitmap(openFileDialog.FileName);
                        PictureBoxInput.Image = originalImage;  // Display the selected image
                        ButtonInput.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBoxProbability.Text, out double errorProbability) || errorProbability < 0 || errorProbability > 1)
            {
                MessageBox.Show("Invalid error probability input");
                return;
            }

            if (originalImage == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            // Step 1: Convert image to bits and store width and height
            int width = originalImage.Width;
            int height = originalImage.Height;
            int[] imageBits = ImageToBits(originalImage, out width, out height);

            // Step 2: Pad bit array to make its length a multiple of 12
            int neededBits = (12 - (imageBits.Length % 12)) % 12;
            int[] paddedBitArray = new int[imageBits.Length + neededBits];
            Array.Copy(imageBits, paddedBitArray, imageBits.Length);

            // Step 3: Split padded bit array into 12-bit vectors
            List<int> encodedAndDecodedBits = new List<int>();
            List<int> noisyUnencodedBits = new List<int>();

            foreach (var vector in SplitBitArray(paddedBitArray, 12))
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

            // Step 4: Convert bit arrays back to images
            Bitmap encodedDecodedImage = BitsToImage(encodedAndDecodedBits.ToArray(), width, height);
            Bitmap noisyUnencodedImage = BitsToImage(noisyUnencodedBits.ToArray(), width, height);

            // Step 5: Display results
            PictureBoxWithEncoding.Image = encodedDecodedImage;
            PictureBoxWithoutEncoding.Image = noisyUnencodedImage;
        }

        private int[] ImageToBits(Bitmap image, out int width, out int height)
        {
            width = image.Width;
            height = image.Height;
            List<int> bitList = new List<int>();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    bitList.AddRange(ColorToBits(pixel));
                }
            }
            return bitList.ToArray();
        }

        private IEnumerable<int[]> SplitBitArray(int[] bits, int size)
        {
            for (int i = 0; i <= bits.Length - size; i += size)
            {
                yield return bits.Skip(i).Take(size).ToArray();
            }
        }

        private Bitmap BitsToImage(int[] bits, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            int bitIndex = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (bitIndex + 24 <= bits.Length)
                    {
                        Color pixel = BitsToColor(bits, ref bitIndex);
                        result.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        result.SetPixel(x, y, Color.Black); // Fill missing pixels
                    }
                }
            }
            return result;
        }

        private List<int> ColorToBits(Color color)
        {
            List<int> bits = new List<int>();
            bits.AddRange(ByteToBits(color.R));
            bits.AddRange(ByteToBits(color.G));
            bits.AddRange(ByteToBits(color.B));
            return bits;
        }

        private Color BitsToColor(int[] bits, ref int bitIndex)
        {
            int r = BitsToByte(bits, ref bitIndex);
            int g = BitsToByte(bits, ref bitIndex);
            int b = BitsToByte(bits, ref bitIndex);
            return Color.FromArgb(r, g, b);
        }

        private int[] ByteToBits(byte value)
        {
            int[] bits = new int[8];
            for (int i = 7; i >= 0; i--)
            {
                bits[7 - i] = (value >> i) & 1;
            }
            return bits;
        }

        private int BitsToByte(int[] bits, ref int index)
        {
            int value = 0;
            for (int i = 0; i < 8; i++)
            {
                value = (value << 1) | bits[index++];
            }
            return value;
        }

        private void HomeButton_Click(object sender, EventArgs e)
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
