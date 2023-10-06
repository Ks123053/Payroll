using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payrll
{
    public partial class Login_1 : Form
    {
        public Login_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_user.Text=="admin" && txt_pass.Text == "admin")
            {
                MainForm a = new MainForm();
                this.Hide();
                a.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
