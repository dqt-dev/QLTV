using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinhV1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_QLTL_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlMuon1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlTra1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlQLĐG1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlXLĐG1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlInfo1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlPass1.BringToFront();
        }
    }
}
