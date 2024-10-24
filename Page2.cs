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
    public partial class Page2 : Form
    {

        private int[] encodedVector;

        public Page2(int[] vector) 
        {
            InitializeComponent();

            // saving received encoded vector value in class level variable 'encodedVector' for easier access
            encodedVector = vector;

            string encodedVectorString = string.Join(" ", encodedVector);

            LabelEncodedData.Text = encodedVectorString;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string probability = TextBoxProbability.Text;

            double errorProbability = Convert.ToDouble(probability);

            // Simulate noisy channel
            int[] noisyVector = Program.SimulateNoisyChannel(encodedVector, errorProbability);

            string noisyVectorString = string.Join(" ", noisyVector);

            LabelReceived.Text = noisyVectorString;
        }
    }
}
