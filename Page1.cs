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
    public partial class Page1 : Form
    {

        public int[] inputVector;

        public Page1()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            // Predefined matrix 12x23 (can be changed to any valid binary matrix)
            int[,] matrix = new int[12, 23]
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

            // Retrieve and parse the vector input from the TextBox
            try
            {
                // Split the input based on spaces or commas
                string[] input = InputVector.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Convert the string array to an integer array
                int[] vector = Array.ConvertAll(input, int.Parse);

                // Validate the length of the input
                if (vector.Length != 12)
                {
                    MessageBox.Show("The input vector must be exactly 12 elements long.");
                    return;
                }

                inputVector = vector;

                // Call the MultiplyVectorByMatrix function
                int[] result = Program.MultiplyVectorByMatrix(vector, matrix);

                // Create an instance of Form2
                Page2 page2 = new Page2(result);
                page2.Show();
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
    }
}
