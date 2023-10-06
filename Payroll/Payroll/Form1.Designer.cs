namespace Payroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_user = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_Pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.Location = new System.Drawing.Point(105, 43);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(60, 15);
            this.txt_user.TabIndex = 0;
            this.txt_user.Text = "Username";
            // 
            // txt_pass
            // 
            this.txt_pass.AutoSize = true;
            this.txt_pass.Location = new System.Drawing.Point(105, 145);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(57, 15);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "Password";
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(105, 90);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(216, 23);
            this.text_user.TabIndex = 2;
            // 
            // text_Pass
            // 
            this.text_Pass.Location = new System.Drawing.Point(105, 191);
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.Size = new System.Drawing.Size(216, 23);
            this.text_Pass.TabIndex = 3;
            this.text_Pass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_Pass);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Name = "Form1";
            this.Text = "Login";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt_user;
        private Label txt_pass;
        private TextBox text_user;
        private TextBox text_Pass;
        private Button button1;
        private Button button2;
    }
}