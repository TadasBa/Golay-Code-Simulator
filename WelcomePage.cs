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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Page1 page1 = new Page1();

            page1.Show();

            this.Hide();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
