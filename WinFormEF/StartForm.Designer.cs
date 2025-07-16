namespace WinFormEF
{
    partial class StartForm
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
            WelcomeText = new RichTextBox();
            catpronavbtn = new Button();
            drivernavbtn = new Button();
            deliverynavbtn = new Button();
            customernavbtn = new Button();
            SuspendLayout();
            // 
            // WelcomeText
            // 
            WelcomeText.Location = new Point(307, 89);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(171, 29);
            WelcomeText.TabIndex = 0;
            WelcomeText.Text = "Welcome to my project!";
            WelcomeText.Visible = false;
            WelcomeText.TextChanged += richTextBox1_TextChanged;
            // 
            // catpronavbtn
            // 
            catpronavbtn.Location = new Point(307, 124);
            catpronavbtn.Name = "catpronavbtn";
            catpronavbtn.Size = new Size(181, 64);
            catpronavbtn.TabIndex = 1;
            catpronavbtn.Text = "Categories And Products";
            catpronavbtn.UseVisualStyleBackColor = true;
            catpronavbtn.Click += catpronavbtn_Click;
            // 
            // drivernavbtn
            // 
            drivernavbtn.Location = new Point(199, 194);
            drivernavbtn.Name = "drivernavbtn";
            drivernavbtn.Size = new Size(125, 64);
            drivernavbtn.TabIndex = 2;
            drivernavbtn.Text = "Driver";
            drivernavbtn.UseVisualStyleBackColor = true;
            // 
            // deliverynavbtn
            // 
            deliverynavbtn.Location = new Point(336, 194);
            deliverynavbtn.Name = "deliverynavbtn";
            deliverynavbtn.Size = new Size(125, 64);
            deliverynavbtn.TabIndex = 3;
            deliverynavbtn.Text = "Delivery";
            deliverynavbtn.UseVisualStyleBackColor = true;
            // 
            // customernavbtn
            // 
            customernavbtn.Location = new Point(467, 194);
            customernavbtn.Name = "customernavbtn";
            customernavbtn.Size = new Size(125, 64);
            customernavbtn.TabIndex = 4;
            customernavbtn.Text = "Customer";
            customernavbtn.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customernavbtn);
            Controls.Add(deliverynavbtn);
            Controls.Add(drivernavbtn);
            Controls.Add(catpronavbtn);
            Controls.Add(WelcomeText);
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox WelcomeText;
        private Button catpronavbtn;
        private Button drivernavbtn;
        private Button deliverynavbtn;
        private Button customernavbtn;
    }
}