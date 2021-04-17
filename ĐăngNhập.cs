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
    public partial class ĐăngNhập : Form
    {
        public ĐăngNhập()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.ShowDialog();
            f.Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thông báo", "Bạn có muốn thoát không", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtbPassWord.UseSystemPasswordChar = true;
            }
        }

        private void txtbNameUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtbNameUser.SelectAll();
        }

        private void txtbPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            txtbPassWord.SelectAll();
        }
    }
}
