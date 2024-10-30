using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Golay_Code
{
    public partial class DecodePage : Form
    {
        public DecodePage(int[] receivedVector, int[] sentVector, int[] inputVector)
        {
            InitializeComponent();
            InitializeVectors(sentVector, receivedVector, inputVector);
            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void InitializeVectors(int[] sentVector, int[] receivedVector, int[] inputVector)
        {
            LabelSent.Text = string.Join(" ", sentVector);
            TextBoxReceived.Text = string.Join(" ", receivedVector);
            LabelInput.Text = string.Join(" ", inputVector);

            UpdateErrorPositions(sentVector, receivedVector);
        }

        private void UpdateErrorPositions(int[] sentVector, int[] receivedVector)
        {
            int[] errorPositions = Vectors.CheckErrorPositions(sentVector, receivedVector);
            LabelErrorPositions.Text = string.Join(", ", errorPositions);
            LabelErrors.Text = errorPositions.Length.ToString();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int[] sentVector = LabelSent.Text.Split(' ').Select(int.Parse).ToArray();
            int[] receivedVector = TextBoxReceived.Text.Split(' ').Select(int.Parse).ToArray();
            UpdateErrorPositions(sentVector, receivedVector);
        }

        private void ButtonDecode_Click(object sender, EventArgs e)
        {         
            int[] receivedVector = TextBoxReceived.Text.Split(' ').Select(int.Parse).ToArray();
            int[] decodedVector = Decoder.Decode(receivedVector, Matrices.GetMatrixH(), Matrices.GetMatrixB());
            LabelDecoded.Text = string.Join(" ", decodedVector);
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
