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
        public Page3(int[] receivedVector, int[] sentVector)
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
