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
    
    public partial class Home : Form
    {
        //private Button buttons;
        private Form activeForm;
        public Home()
        {
            InitializeComponent();
            button_Home.Visible = false;
        }
        //private void activeButton(object e)
        //{
        //    if(e != null)
        //    {
        //        if(buttons != (Button)e)
        //        {
        //            button_Home.Visible = true;
        //        }
        //    }
        //}

        private void OpenForm(Form childForm, object o)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_destop.Controls.Add(childForm);
            panel_destop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label2.Text = childForm.Text;
            button_Home.Visible = true;
        }
        private void Reset()
        {
            
            label2.Text = "QUẢN LÝ THƯ VIỆN";
            //buttons = null;
            button_Home.Visible = false;

        }
        private void button8_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlInfo1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlQLTL1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlMuon2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlTra2.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button_Home.Visible = false;
            userControlHome5.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlQLNV2.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlQLĐG2.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlBC2.BringToFront();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlPass1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Home.Visible = true;
            userControlXLĐG1.BringToFront();
        }
    }

    
}
