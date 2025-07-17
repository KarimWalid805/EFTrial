namespace WinFormEF
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernamelbl = new Label();
            passwordlbl = new Label();
            conpasslbl = new Label();
            txtusername = new TextBox();
            txtconfirmpassword = new TextBox();
            txtpassword = new TextBox();
            registerbtn = new Button();
            loginbtn = new Button();
            SuspendLayout();
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(54, 100);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(120, 20);
            usernamelbl.TabIndex = 0;
            usernamelbl.Text = "Enter User Name";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(54, 133);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(108, 20);
            passwordlbl.TabIndex = 1;
            passwordlbl.Text = "Enter Password";
            // 
            // conpasslbl
            // 
            conpasslbl.AutoSize = true;
            conpasslbl.Location = new Point(54, 166);
            conpasslbl.Name = "conpasslbl";
            conpasslbl.Size = new Size(127, 20);
            conpasslbl.TabIndex = 2;
            conpasslbl.Text = "Confirm Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(189, 100);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 3;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Location = new Point(187, 166);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(125, 27);
            txtconfirmpassword.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(189, 133);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 5;
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(105, 214);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(125, 29);
            registerbtn.TabIndex = 6;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(86, 249);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(166, 29);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "Have Account? Login Now";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginbtn);
            Controls.Add(registerbtn);
            Controls.Add(txtpassword);
            Controls.Add(txtconfirmpassword);
            Controls.Add(txtusername);
            Controls.Add(conpasslbl);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
            Name = "loginForm";
            Text = "loginForm";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernamelbl;
        private Label passwordlbl;
        private Label conpasslbl;
        private TextBox txtusername;
        private TextBox txtconfirmpassword;
        private TextBox txtpassword;
        private Button registerbtn;
        private Button loginbtn;
    }
}