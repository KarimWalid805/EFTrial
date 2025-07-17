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
            driverRadio = new RadioButton();
            customerRadio = new RadioButton();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(20, 24);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(116, 20);
            usernamelbl.TabIndex = 0;
            usernamelbl.Text = "Enter Username:";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(20, 60);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(111, 20);
            passwordlbl.TabIndex = 1;
            passwordlbl.Text = "Enter Password:";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(155, 24);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(169, 27);
            usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(155, 60);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(169, 27);
            passwordtxt.TabIndex = 3;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(118, 107);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(86, 39);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(77, 152);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(178, 62);
            registerbtn.TabIndex = 5;
            registerbtn.Text = "Don't Have Account? Create";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(customerRadio);
            GroupBox.Controls.Add(driverRadio);
            GroupBox.Location = new Point(345, 24);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(203, 215);
            GroupBox.TabIndex = 6;
            GroupBox.TabStop = false;
            GroupBox.Text = "Driver/Customer";
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 281);
            Controls.Add(GroupBox);
            Controls.Add(registerbtn);
            Controls.Add(loginbtn);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
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
    }
}