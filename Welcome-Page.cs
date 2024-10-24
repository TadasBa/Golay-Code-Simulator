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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Page1 page1 = new Page1();

            page1.Show();

            this.Hide();
        }
    }
}
