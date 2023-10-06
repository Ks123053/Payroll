using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "admin" && txt_user.Text == "admin")
            {
                MainForm a = new MainForm();
                this.Hide();
                a.Show();
            }
            else if (txt_pass.Text == "" || txt_user.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
            }
            else
            {
                MessageBox.Show("Incorrect username/password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }
    }
}
