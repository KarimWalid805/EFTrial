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
            components = new System.ComponentModel.Container();
            FNamelbl = new Label();
            LNamelbl = new Label();
            Address = new Label();
            FirstNametxt = new TextBox();
            LastNametxt = new TextBox();
            Addresstxt = new TextBox();
            ProductListBox = new CheckedListBox();
            welcomelbl = new Label();
            label2 = new Label();
            label3 = new Label();
            OrderGridView = new DataGridView();
            ordersIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productslistDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            cancelorderbtn = new Button();
            customerBindingSource = new BindingSource(components);
            AddCust = new Button();
            firstnamewelcome = new TextBox();
            pictureBox1 = new PictureBox();
            usernametxt = new TextBox();
            SearchBox = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FNamelbl
            // 
            FNamelbl.AutoSize = true;
            FNamelbl.Location = new Point(23, 142);
            FNamelbl.Name = "FNamelbl";
            FNamelbl.Size = new Size(127, 15);
            FNamelbl.TabIndex = 1;
            FNamelbl.Text = "Customer's First Name";
            // 
            // LNamelbl
            // 
            LNamelbl.AutoSize = true;
            LNamelbl.Location = new Point(23, 166);
            LNamelbl.Name = "LNamelbl";
            LNamelbl.Size = new Size(126, 15);
            LNamelbl.TabIndex = 2;
            LNamelbl.Text = "Customer's Last Name";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(23, 191);
            Address.Name = "Address";
            Address.Size = new Size(112, 15);
            Address.TabIndex = 3;
            Address.Text = "Customer's Address";
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(164, 142);
            FirstNametxt.Margin = new Padding(3, 2, 3, 2);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(126, 23);
            FirstNametxt.TabIndex = 5;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(164, 166);
            LastNametxt.Margin = new Padding(3, 2, 3, 2);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(126, 23);
            LastNametxt.TabIndex = 6;
            // 
            // Addresstxt
            // 
            Addresstxt.Location = new Point(164, 191);
            Addresstxt.Margin = new Padding(3, 2, 3, 2);
            Addresstxt.Name = "Addresstxt";
            Addresstxt.Size = new Size(126, 23);
            Addresstxt.TabIndex = 8;
            // 
            // ProductListBox
            // 
            ProductListBox.FormattingEnabled = true;
            ProductListBox.Location = new Point(24, 277);
            ProductListBox.Margin = new Padding(3, 2, 3, 2);
            ProductListBox.Name = "ProductListBox";
            ProductListBox.Size = new Size(228, 310);
            ProductListBox.TabIndex = 9;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.BackColor = Color.Transparent;
            welcomelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelbl.Location = new Point(24, 72);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(242, 30);
            welcomelbl.TabIndex = 11;
            welcomelbl.Text = "Welcome To the Shop,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 109);
            label2.Name = "label2";
            label2.Size = new Size(447, 15);
            label2.TabIndex = 12;
            label2.Text = "Submit your details, then choose the products you would like to add to your order.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(666, 124);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 14;
            label3.Text = "Your Order(s):";
            // 
            // OrderGridView
            // 
            OrderGridView.AutoGenerateColumns = false;
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Columns.AddRange(new DataGridViewColumn[] { ordersIdDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn1, orderDateDataGridViewTextBoxColumn, productslistDataGridViewTextBoxColumn });
            OrderGridView.DataSource = bindingSource1;
            OrderGridView.Location = new Point(416, 141);
            OrderGridView.Margin = new Padding(3, 2, 3, 2);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.Size = new Size(554, 445);
            OrderGridView.TabIndex = 15;
            // 
            // ordersIdDataGridViewTextBoxColumn
            // 
            ordersIdDataGridViewTextBoxColumn.DataPropertyName = "OrdersId";
            ordersIdDataGridViewTextBoxColumn.HeaderText = "OrdersId";
            ordersIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ordersIdDataGridViewTextBoxColumn.Name = "ordersIdDataGridViewTextBoxColumn";
            ordersIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            addressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            addressDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "orderDate";
            orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // productslistDataGridViewTextBoxColumn
            // 
            productslistDataGridViewTextBoxColumn.DataPropertyName = "products_list";
            productslistDataGridViewTextBoxColumn.HeaderText = "products_list";
            productslistDataGridViewTextBoxColumn.MinimumWidth = 6;
            productslistDataGridViewTextBoxColumn.Name = "productslistDataGridViewTextBoxColumn";
            productslistDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Customers.Orders);
            // 
            // cancelorderbtn
            // 
            cancelorderbtn.ForeColor = Color.Red;
            cancelorderbtn.Location = new Point(296, 167);
            cancelorderbtn.Margin = new Padding(3, 2, 3, 2);
            cancelorderbtn.Name = "cancelorderbtn";
            cancelorderbtn.Size = new Size(117, 22);
            cancelorderbtn.TabIndex = 17;
            cancelorderbtn.Text = "Cancel Order";
            cancelorderbtn.UseVisualStyleBackColor = true;
            cancelorderbtn.Click += cancelorderbtn_Click;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customers.Customer);
            // 
            // AddCust
            // 
            AddCust.ForeColor = Color.FromArgb(0, 192, 0);
            AddCust.Location = new Point(296, 141);
            AddCust.Margin = new Padding(3, 2, 3, 2);
            AddCust.Name = "AddCust";
            AddCust.Size = new Size(116, 22);
            AddCust.TabIndex = 22;
            AddCust.Text = "Make Order";
            AddCust.UseVisualStyleBackColor = true;
            AddCust.Click += MakeOrder_Click;
            // 
            // firstnamewelcome
            // 
            firstnamewelcome.BorderStyle = BorderStyle.None;
            firstnamewelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            firstnamewelcome.Location = new Point(261, 72);
            firstnamewelcome.Name = "firstnamewelcome";
            firstnamewelcome.Size = new Size(100, 29);
            firstnamewelcome.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(666, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.DarkSlateGray;
            usernametxt.BorderStyle = BorderStyle.None;
            usernametxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            usernametxt.ForeColor = SystemColors.MenuBar;
            usernametxt.Location = new Point(703, 29);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(267, 29);
            usernametxt.TabIndex = 25;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(61, 234);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(152, 23);
            SearchBox.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vector_find_icon_167101148;
            pictureBox2.Location = new Point(24, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 606);
            Controls.Add(pictureBox2);
            Controls.Add(SearchBox);
            Controls.Add(usernametxt);
            Controls.Add(pictureBox1);
            Controls.Add(firstnamewelcome);
            Controls.Add(AddCust);
            Controls.Add(cancelorderbtn);
            Controls.Add(OrderGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(welcomelbl);
            Controls.Add(ProductListBox);
            Controls.Add(Addresstxt);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(Address);
            Controls.Add(LNamelbl);
            Controls.Add(FNamelbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomersForm";
            Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FNamelbl;
        private Label LNamelbl;
        private Label Address;
        private TextBox FirstNametxt;
        private TextBox LastNametxt;
        private TextBox Addresstxt;
        private CheckedListBox ProductListBox;
        private Label welcomelbl;
        private Label label2;
        private Label label3;
        private DataGridView OrderGridView;
        private Button cancelorderbtn;
        private Button AddCust;
        private DataGridViewTextBoxColumn ordersIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productslistDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private TextBox firstnamewelcome;
        private PictureBox pictureBox1;
        private TextBox usernametxt;
        private TextBox SearchBox;
        private PictureBox pictureBox2;
    }
}