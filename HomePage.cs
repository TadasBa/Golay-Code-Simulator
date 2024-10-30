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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(ComboBoxInputType.Text == "Vector")
            {
                EncodePage encodePage = new EncodePage();
                encodePage.Show();
                this.Hide();
            }
            if (ComboBoxInputType.Text == "Text")
            {
                TextPage textPage = new TextPage();
                textPage.Show();
                this.Hide();

            }
            if (ComboBoxInputType.Text == "Image")
            {
                ImagePage imagePage = new ImagePage();
                imagePage.Show();
                this.Hide();
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
