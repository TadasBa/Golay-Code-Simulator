﻿using System;
using System.Windows.Forms;

namespace Golay_Code
{
    public partial class EncodePage : Form
    {
        public int[] inputVector;

        public EncodePage()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void ButtonEncode_Click(object sender, EventArgs e)
        {
            try
            {
                inputVector = Vectors.ParseInputVector(InputVector.Text);

                if (inputVector.Length != 12)
                {
                    MessageBox.Show("The input vector must be exactly 12 elements long.");
                    return;
                }

                int[] encodedResult = Encoder.Encode(inputVector, Matrices.GetMatrixG());

                ChannelPage channelPage = new ChannelPage(encodedResult, inputVector);
                channelPage.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a binary vector (0s and 1s only).");
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
