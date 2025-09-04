namespace WinFormEF
{
    partial class LoginForm
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
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            loginbtn = new Button();
            registerbtn = new Button();
            GroupBox = new GroupBox();
            adminRadio = new RadioButton();
            customerRadio = new RadioButton();
            driverRadio = new RadioButton();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(15, 68);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(93, 15);
            usernamelbl.TabIndex = 0;
            usernamelbl.Text = "Enter Username:";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(15, 94);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(90, 15);
            passwordlbl.TabIndex = 1;
            passwordlbl.Text = "Enter Password:";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(133, 68);
            usernametxt.Margin = new Padding(3, 2, 3, 2);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(148, 23);
            usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(133, 94);
            passwordtxt.Margin = new Padding(3, 2, 3, 2);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(148, 23);
            passwordtxt.TabIndex = 3;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(101, 130);
            loginbtn.Margin = new Padding(3, 2, 3, 2);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(75, 29);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(65, 164);
            registerbtn.Margin = new Padding(3, 2, 3, 2);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(156, 46);
            registerbtn.TabIndex = 5;
            registerbtn.Text = "Don't Have Account? Create";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(adminRadio);
            GroupBox.Controls.Add(customerRadio);
            GroupBox.Controls.Add(driverRadio);
            GroupBox.Location = new Point(295, 68);
            GroupBox.Margin = new Padding(3, 2, 3, 2);
            GroupBox.Name = "GroupBox";
            GroupBox.Padding = new Padding(3, 2, 3, 2);
            GroupBox.Size = new Size(178, 106);
            GroupBox.TabIndex = 6;
            GroupBox.TabStop = false;
            GroupBox.Text = "You are a(n):";
            // 
            // adminRadio
            // 
            adminRadio.AutoSize = true;
            adminRadio.Location = new Point(40, 74);
            adminRadio.Margin = new Padding(3, 2, 3, 2);
            adminRadio.Name = "adminRadio";
            adminRadio.Size = new Size(61, 19);
            adminRadio.TabIndex = 2;
            adminRadio.TabStop = true;
            adminRadio.Text = "Admin";
            adminRadio.UseVisualStyleBackColor = true;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 229);
            Controls.Add(GroupBox);
            Controls.Add(registerbtn);
            Controls.Add(loginbtn);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernamelbl;
        private Label passwordlbl;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Button loginbtn;
        private Button registerbtn;
        private GroupBox GroupBox;
        private RadioButton customerRadio;
        private RadioButton driverRadio;
        private RadioButton adminRadio;
    }
}