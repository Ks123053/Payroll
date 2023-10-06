namespace Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(text_Pass.Text == "admin" && text_user.Text == "admin")
            {
                MainForm a = new MainForm();
                this.Hide();
                a.Show();
            }
            else if(text_Pass.Text == "" || text_user.Text=="")
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

        
    }
}