using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Shop
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            texPasscode.Text = texPasscode.Text + "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            texPasscode.Text = "";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //connect to sql and define login credentials
            Table_Selection ts = new Table_Selection();
            ts.ShowDialog();
            this.Hide();
        }
    }
}
