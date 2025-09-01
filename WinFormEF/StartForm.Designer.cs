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
            catpronavbtn = new Button();
            drivernavbtn = new Button();
            deliverynavbtn = new Button();
            customernavbtn = new Button();
            welcomelbl = new Label();
            desclbl = new Label();
            SuspendLayout();
            // 
            // catpronavbtn
            // 
            catpronavbtn.Location = new Point(149, 178);
            catpronavbtn.Name = "catpronavbtn";
            catpronavbtn.Size = new Size(125, 64);
            catpronavbtn.TabIndex = 1;
            catpronavbtn.Text = "Categories And Products";
            catpronavbtn.UseVisualStyleBackColor = true;
            catpronavbtn.Click += catpronavbtn_Click;
            // 
            // drivernavbtn
            // 
            drivernavbtn.Location = new Point(149, 248);
            drivernavbtn.Name = "drivernavbtn";
            drivernavbtn.Size = new Size(125, 64);
            drivernavbtn.TabIndex = 2;
            drivernavbtn.Text = "Driver";
            drivernavbtn.UseVisualStyleBackColor = true;
            drivernavbtn.Click += drivernavbtn_Click;
            // 
            // deliverynavbtn
            // 
            deliverynavbtn.Location = new Point(280, 178);
            deliverynavbtn.Name = "deliverynavbtn";
            deliverynavbtn.Size = new Size(125, 64);
            deliverynavbtn.TabIndex = 3;
            deliverynavbtn.Text = "Delivery";
            deliverynavbtn.UseVisualStyleBackColor = true;
            deliverynavbtn.Click += deliverynavbtn_Click;
            // 
            // customernavbtn
            // 
            customernavbtn.Location = new Point(280, 248);
            customernavbtn.Name = "customernavbtn";
            customernavbtn.Size = new Size(125, 64);
            customernavbtn.TabIndex = 4;
            customernavbtn.Text = "Customer";
            customernavbtn.UseVisualStyleBackColor = true;
            customernavbtn.Click += customernavbtn_Click;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcomelbl.Location = new Point(12, 66);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(364, 20);
            welcomelbl.TabIndex = 5;
            welcomelbl.Text = "Welcome to my PRAC 300 Windows Form Project!";
            // 
            // desclbl
            // 
            desclbl.AutoSize = true;
            desclbl.Location = new Point(152, 155);
            desclbl.Name = "desclbl";
            desclbl.Size = new Size(253, 20);
            desclbl.TabIndex = 6;
            desclbl.Text = "Choose the table(s) you want to edit!";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 423);
            Controls.Add(desclbl);
            Controls.Add(welcomelbl);
            Controls.Add(customernavbtn);
            Controls.Add(deliverynavbtn);
            Controls.Add(drivernavbtn);
            Controls.Add(catpronavbtn);
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox WelcomeText;
        private Button catpronavbtn;
        private Button drivernavbtn;
        private Button deliverynavbtn;
        private Button customernavbtn;
        private Label welcomelbl;
        private Label desclbl;
    }
}