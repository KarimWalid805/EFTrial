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
            FNamelbl = new Label();
            LNamelbl = new Label();
            Orderlbl = new Label();
            Address = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            welcomelbl = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            addorderbtn = new Button();
            cancelorderbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FNamelbl
            // 
            FNamelbl.AutoSize = true;
            FNamelbl.Location = new Point(11, 101);
            FNamelbl.Name = "FNamelbl";
            FNamelbl.Size = new Size(156, 20);
            FNamelbl.TabIndex = 1;
            FNamelbl.Text = "Customer's First Name";
            // 
            // LNamelbl
            // 
            LNamelbl.AutoSize = true;
            LNamelbl.Location = new Point(11, 134);
            LNamelbl.Name = "LNamelbl";
            LNamelbl.Size = new Size(155, 20);
            LNamelbl.TabIndex = 2;
            LNamelbl.Text = "Customer's Last Name";
            // 
            // Orderlbl
            // 
            Orderlbl.AutoSize = true;
            Orderlbl.Location = new Point(15, 200);
            Orderlbl.Name = "Orderlbl";
            Orderlbl.Size = new Size(134, 20);
            Orderlbl.TabIndex = 4;
            Orderlbl.Text = "Submit Your Order:";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(15, 167);
            Address.Name = "Address";
            Address.Size = new Size(138, 20);
            Address.TabIndex = 3;
            Address.Text = "Customer's Address";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 27);
            textBox4.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(23, 223);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(143, 136);
            checkedListBox1.TabIndex = 9;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelbl.Location = new Point(12, 9);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(311, 38);
            welcomelbl.TabIndex = 11;
            welcomelbl.Text = "Welcome To the Shop!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 58);
            label2.Name = "label2";
            label2.Size = new Size(566, 20);
            label2.TabIndex = 12;
            label2.Text = "Submit your details, then choose the products you would like to add to your order.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 104);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 14;
            label3.Text = "Your Order:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 202);
            dataGridView1.TabIndex = 15;
            // 
            // addorderbtn
            // 
            addorderbtn.Location = new Point(181, 223);
            addorderbtn.Name = "addorderbtn";
            addorderbtn.Size = new Size(134, 29);
            addorderbtn.TabIndex = 16;
            addorderbtn.Text = "Make Order";
            addorderbtn.UseVisualStyleBackColor = true;
            // 
            // cancelorderbtn
            // 
            cancelorderbtn.Location = new Point(181, 258);
            cancelorderbtn.Name = "cancelorderbtn";
            cancelorderbtn.Size = new Size(134, 29);
            cancelorderbtn.TabIndex = 17;
            cancelorderbtn.Text = "Cancel Order";
            cancelorderbtn.UseVisualStyleBackColor = true;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 400);
            Controls.Add(cancelorderbtn);
            Controls.Add(addorderbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(welcomelbl);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Orderlbl);
            Controls.Add(Address);
            Controls.Add(LNamelbl);
            Controls.Add(FNamelbl);
            Name = "CustomersForm";
            Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FNamelbl;
        private Label LNamelbl;
        private Label Orderlbl;
        private Label Address;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private CheckedListBox checkedListBox1;
        private Label welcomelbl;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button addorderbtn;
        private Button cancelorderbtn;
    }
}