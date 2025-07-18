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
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(28, 40);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(120, 20);
            usernamelbl.TabIndex = 0;
            usernamelbl.Text = "Enter User Name";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(28, 73);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(108, 20);
            passwordlbl.TabIndex = 1;
            passwordlbl.Text = "Enter Password";
            // 
            // conpasslbl
            // 
            conpasslbl.AutoSize = true;
            conpasslbl.Location = new Point(28, 106);
            conpasslbl.Name = "conpasslbl";
            conpasslbl.Size = new Size(127, 20);
            conpasslbl.TabIndex = 2;
            conpasslbl.Text = "Confirm Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(163, 40);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 3;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Location = new Point(161, 106);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(125, 27);
            txtconfirmpassword.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(163, 73);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 5;
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(79, 154);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(125, 29);
            registerbtn.TabIndex = 6;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(60, 189);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(166, 29);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "Have Account? Login Now";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(customerRadio);
            GroupBox.Controls.Add(driverRadio);
            GroupBox.Location = new Point(326, 12);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(203, 215);
            GroupBox.TabIndex = 8;
            GroupBox.TabStop = false;
            GroupBox.Text = "Driver/Customer";
            // 
            // customerRadio
            // 
            customerRadio.AutoSize = true;
            customerRadio.Location = new Point(44, 73);
            customerRadio.Name = "customerRadio";
            customerRadio.Size = new Size(93, 24);
            customerRadio.TabIndex = 1;
            customerRadio.TabStop = true;
            customerRadio.Text = "Customer";
            customerRadio.UseVisualStyleBackColor = true;
            // 
            // driverRadio
            // 
            driverRadio.AutoSize = true;
            driverRadio.Location = new Point(45, 39);
            driverRadio.Name = "driverRadio";
            driverRadio.Size = new Size(70, 24);
            driverRadio.TabIndex = 0;
            driverRadio.TabStop = true;
            driverRadio.Text = "Driver";
            driverRadio.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 255);
            Controls.Add(GroupBox);
            Controls.Add(loginbtn);
            Controls.Add(registerbtn);
            Controls.Add(txtpassword);
            Controls.Add(txtconfirmpassword);
            Controls.Add(txtusername);
            Controls.Add(conpasslbl);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
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
    }
}