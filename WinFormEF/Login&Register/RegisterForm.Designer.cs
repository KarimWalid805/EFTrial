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
            GroupBox = new GroupBox();
            customerRadio = new RadioButton();
            driverRadio = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            FirstNametxt = new TextBox();
            LastNametxt = new TextBox();
            Addresstxt = new TextBox();
            Addresslbl = new Label();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(29, 174);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(95, 15);
            usernamelbl.TabIndex = 0;
            usernamelbl.Text = "Enter User Name";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(29, 199);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(87, 15);
            passwordlbl.TabIndex = 1;
            passwordlbl.Text = "Enter Password";
            // 
            // conpasslbl
            // 
            conpasslbl.AutoSize = true;
            conpasslbl.Location = new Point(29, 224);
            conpasslbl.Name = "conpasslbl";
            conpasslbl.Size = new Size(104, 15);
            conpasslbl.TabIndex = 2;
            conpasslbl.Text = "Confirm Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(147, 174);
            txtusername.Margin = new Padding(3, 2, 3, 2);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(100, 23);
            txtusername.TabIndex = 3;
            txtusername.TabStop = false;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Location = new Point(146, 224);
            txtconfirmpassword.Margin = new Padding(3, 2, 3, 2);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.PasswordChar = '*';
            txtconfirmpassword.Size = new Size(101, 23);
            txtconfirmpassword.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(147, 199);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(100, 23);
            txtpassword.TabIndex = 5;
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(29, 257);
            registerbtn.Margin = new Padding(3, 2, 3, 2);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(109, 38);
            registerbtn.TabIndex = 6;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(144, 257);
            loginbtn.Margin = new Padding(3, 2, 3, 2);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(145, 38);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "Have Account? Login Now";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(customerRadio);
            GroupBox.Controls.Add(driverRadio);
            GroupBox.Location = new Point(274, 141);
            GroupBox.Margin = new Padding(3, 2, 3, 2);
            GroupBox.Name = "GroupBox";
            GroupBox.Padding = new Padding(3, 2, 3, 2);
            GroupBox.Size = new Size(178, 107);
            GroupBox.TabIndex = 8;
            GroupBox.TabStop = false;
            GroupBox.Text = "Register as a:";
            // 
            // customerRadio
            // 
            customerRadio.AutoSize = true;
            customerRadio.Location = new Point(39, 52);
            customerRadio.Margin = new Padding(3, 2, 3, 2);
            customerRadio.Name = "customerRadio";
            customerRadio.Size = new Size(77, 19);
            customerRadio.TabIndex = 1;
            customerRadio.TabStop = true;
            customerRadio.Text = "Customer";
            customerRadio.UseVisualStyleBackColor = true;
            // 
            // driverRadio
            // 
            driverRadio.AutoSize = true;
            driverRadio.Location = new Point(39, 29);
            driverRadio.Margin = new Padding(3, 2, 3, 2);
            driverRadio.Name = "driverRadio";
            driverRadio.Size = new Size(56, 19);
            driverRadio.TabIndex = 0;
            driverRadio.TabStop = true;
            driverRadio.Text = "Driver";
            driverRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 109);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 109);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(99, 105);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(100, 23);
            FirstNametxt.TabIndex = 0;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(274, 106);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(100, 23);
            LastNametxt.TabIndex = 12;
            // 
            // Addresstxt
            // 
            Addresstxt.Location = new Point(99, 138);
            Addresstxt.Name = "Addresstxt";
            Addresstxt.Size = new Size(100, 23);
            Addresstxt.TabIndex = 14;
            // 
            // Addresslbl
            // 
            Addresslbl.AutoSize = true;
            Addresslbl.Location = new Point(29, 141);
            Addresslbl.Name = "Addresslbl";
            Addresslbl.Size = new Size(49, 15);
            Addresslbl.TabIndex = 13;
            Addresslbl.Text = "Address";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 313);
            Controls.Add(Addresstxt);
            Controls.Add(Addresslbl);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GroupBox);
            Controls.Add(loginbtn);
            Controls.Add(registerbtn);
            Controls.Add(txtpassword);
            Controls.Add(txtconfirmpassword);
            Controls.Add(txtusername);
            Controls.Add(conpasslbl);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            Text = "loginForm";
            Load += loginForm_Load;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
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
        private GroupBox GroupBox;
        private RadioButton customerRadio;
        private RadioButton driverRadio;
        private Label label1;
        private Label label2;
        private TextBox FirstNametxt;
        private TextBox LastNametxt;
        private TextBox Addresstxt;
        private Label Addresslbl;
    }
}