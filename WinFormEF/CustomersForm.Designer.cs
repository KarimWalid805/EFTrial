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
            FirstNametxt = new TextBox();
            LastNametxt = new TextBox();
            Addresstxt = new TextBox();
            ProductCheckedListBox = new CheckedListBox();
            welcomelbl = new Label();
            label2 = new Label();
            label3 = new Label();
            OrderGridView = new DataGridView();
            addorderbtn = new Button();
            cancelorderbtn = new Button();
            label1 = new Label();
            customersDataGridView = new DataGridView();
            Agelbl = new Label();
            agenum = new NumericUpDown();
            AddCust = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agenum).BeginInit();
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
            Orderlbl.Location = new Point(16, 255);
            Orderlbl.Name = "Orderlbl";
            Orderlbl.Size = new Size(134, 20);
            Orderlbl.TabIndex = 4;
            Orderlbl.Text = "Submit Your Order:";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(28, 170);
            Address.Name = "Address";
            Address.Size = new Size(138, 20);
            Address.TabIndex = 3;
            Address.Text = "Customer's Address";
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(172, 101);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(143, 27);
            FirstNametxt.TabIndex = 5;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(172, 134);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(143, 27);
            LastNametxt.TabIndex = 6;
            // 
            // Addresstxt
            // 
            Addresstxt.Location = new Point(172, 167);
            Addresstxt.Name = "Addresstxt";
            Addresstxt.Size = new Size(143, 27);
            Addresstxt.TabIndex = 8;
            // 
            // ProductCheckedListBox
            // 
            ProductCheckedListBox.FormattingEnabled = true;
            ProductCheckedListBox.Location = new Point(24, 278);
            ProductCheckedListBox.Name = "ProductCheckedListBox";
            ProductCheckedListBox.Size = new Size(143, 136);
            ProductCheckedListBox.TabIndex = 9;
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
            // OrderGridView
            // 
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Location = new Point(345, 134);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.Size = new Size(300, 202);
            OrderGridView.TabIndex = 15;
            // 
            // addorderbtn
            // 
            addorderbtn.Location = new Point(182, 278);
            addorderbtn.Name = "addorderbtn";
            addorderbtn.Size = new Size(134, 29);
            addorderbtn.TabIndex = 16;
            addorderbtn.Text = "Make Order";
            addorderbtn.UseVisualStyleBackColor = true;
            // 
            // cancelorderbtn
            // 
            cancelorderbtn.Location = new Point(182, 313);
            cancelorderbtn.Name = "cancelorderbtn";
            cancelorderbtn.Size = new Size(134, 29);
            cancelorderbtn.TabIndex = 17;
            cancelorderbtn.Text = "Cancel Order";
            cancelorderbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 417);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 18;
            label1.Text = "Customers Table";
            // 
            // customersDataGridView
            // 
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.Location = new Point(11, 468);
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.RowHeadersWidth = 51;
            customersDataGridView.Size = new Size(425, 201);
            customersDataGridView.TabIndex = 19;
            // 
            // Agelbl
            // 
            Agelbl.AutoSize = true;
            Agelbl.Location = new Point(130, 209);
            Agelbl.Name = "Agelbl";
            Agelbl.Size = new Size(36, 20);
            Agelbl.TabIndex = 20;
            Agelbl.Text = "Age";
            // 
            // agenum
            // 
            agenum.Location = new Point(173, 207);
            agenum.Name = "agenum";
            agenum.Size = new Size(143, 27);
            agenum.TabIndex = 21;
            // 
            // AddCust
            // 
            AddCust.Location = new Point(486, 447);
            AddCust.Name = "AddCust";
            AddCust.Size = new Size(94, 29);
            AddCust.TabIndex = 22;
            AddCust.Text = "Add";
            AddCust.UseVisualStyleBackColor = true;
            AddCust.Click += AddCust_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 681);
            Controls.Add(AddCust);
            Controls.Add(agenum);
            Controls.Add(Agelbl);
            Controls.Add(customersDataGridView);
            Controls.Add(label1);
            Controls.Add(cancelorderbtn);
            Controls.Add(addorderbtn);
            Controls.Add(OrderGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(welcomelbl);
            Controls.Add(ProductCheckedListBox);
            Controls.Add(Addresstxt);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(Orderlbl);
            Controls.Add(Address);
            Controls.Add(LNamelbl);
            Controls.Add(FNamelbl);
            Name = "CustomersForm";
            Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)agenum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FNamelbl;
        private Label LNamelbl;
        private Label Orderlbl;
        private Label Address;
        private TextBox FirstNametxt;
        private TextBox LastNametxt;
        private TextBox Addresstxt;
        private CheckedListBox ProductCheckedListBox;
        private Label welcomelbl;
        private Label label2;
        private Label label3;
        private DataGridView OrderGridView;
        private Button addorderbtn;
        private Button cancelorderbtn;
        private Label label1;
        private DataGridView customersDataGridView;
        private Label Agelbl;
        private NumericUpDown agenum;
        private Button AddCust;
    }
}