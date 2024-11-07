using System;
using System.Windows.Forms;

namespace Golay_Code
{
    public partial class ChannelPage : Form
    {
        private int[] encodedVector;
        private int[] inputVector;

        public ChannelPage(int[] vector, int[] input)
        {
            InitializeComponent();

            encodedVector = vector;
            inputVector = input;
            LabelEncodedData.Text = string.Join(" ", encodedVector);

            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                double errorProbability = Channel.ParseProbability(TextBoxProbability.Text);
                int[] noisyVector = Channel.SimulateNoisyChannel(encodedVector, errorProbability);

                // Show the results on Page3
                DecodePage decodePage = new DecodePage(noisyVector, encodedVector, inputVector);
                decodePage.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid probability (0 to 1).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
