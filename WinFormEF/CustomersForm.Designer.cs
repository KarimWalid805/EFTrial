namespace WinFormEF
{
    partial class CustomersForm
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
            label1 = new Label();
            FNamelbl = new Label();
            LNamelbl = new Label();
            label4 = new Label();
            Address = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 235);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Here";
            // 
            // FNamelbl
            // 
            FNamelbl.AutoSize = true;
            FNamelbl.Location = new Point(89, 81);
            FNamelbl.Name = "FNamelbl";
            FNamelbl.Size = new Size(156, 20);
            FNamelbl.TabIndex = 1;
            FNamelbl.Text = "Customer's First Name";
            // 
            // LNamelbl
            // 
            LNamelbl.AutoSize = true;
            LNamelbl.Location = new Point(89, 112);
            LNamelbl.Name = "LNamelbl";
            LNamelbl.Size = new Size(155, 20);
            LNamelbl.TabIndex = 2;
            LNamelbl.Text = "Customer's Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 202);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(89, 182);
            Address.Name = "Address";
            Address.Size = new Size(138, 20);
            Address.TabIndex = 3;
            Address.Text = "Customer's Address";
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Address);
            Controls.Add(LNamelbl);
            Controls.Add(FNamelbl);
            Controls.Add(label1);
            Name = "CustomersForm";
            Text = "CustomersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label FNamelbl;
        private Label LNamelbl;
        private Label label4;
        private Label Address;
    }
}