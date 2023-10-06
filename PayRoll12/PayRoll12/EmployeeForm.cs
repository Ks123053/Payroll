using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;




namespace PayRoll12
{
    public partial class EmployeeForm : Form
    {

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table(ID,NAME,AGE) values (@ID,@NAME,@AGE)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("success");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
