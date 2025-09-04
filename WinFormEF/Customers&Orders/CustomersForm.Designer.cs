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
            Orderlbl = new Label();
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
            CustomersTablelbl = new Label();
            customersDataGridView = new DataGridView();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            Agelbl = new Label();
            agenum = new NumericUpDown();
            AddCust = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agenum).BeginInit();
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
            // Orderlbl
            // 
            Orderlbl.AutoSize = true;
            Orderlbl.Location = new Point(28, 257);
            Orderlbl.Name = "Orderlbl";
            Orderlbl.Size = new Size(108, 15);
            Orderlbl.TabIndex = 4;
            Orderlbl.Text = "Submit Your Order:";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(38, 193);
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
            ProductListBox.Location = new Point(35, 274);
            ProductListBox.Margin = new Padding(3, 2, 3, 2);
            ProductListBox.Name = "ProductListBox";
            ProductListBox.Size = new Size(126, 94);
            ProductListBox.TabIndex = 9;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomelbl.Location = new Point(24, 72);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(243, 30);
            welcomelbl.TabIndex = 11;
            welcomelbl.Text = "Welcome To the Shop!";
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
            label3.Location = new Point(316, 144);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 14;
            label3.Text = "Your Order:";
            // 
            // OrderGridView
            // 
            OrderGridView.AutoGenerateColumns = false;
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Columns.AddRange(new DataGridViewColumn[] { ordersIdDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn1, orderDateDataGridViewTextBoxColumn, productslistDataGridViewTextBoxColumn });
            OrderGridView.DataSource = bindingSource1;
            OrderGridView.Location = new Point(316, 166);
            OrderGridView.Margin = new Padding(3, 2, 3, 2);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.Size = new Size(483, 217);
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
            cancelorderbtn.Location = new Point(173, 300);
            cancelorderbtn.Margin = new Padding(3, 2, 3, 2);
            cancelorderbtn.Name = "cancelorderbtn";
            cancelorderbtn.Size = new Size(117, 22);
            cancelorderbtn.TabIndex = 17;
            cancelorderbtn.Text = "Cancel Order";
            cancelorderbtn.UseVisualStyleBackColor = true;
            // 
            // CustomersTablelbl
            // 
            CustomersTablelbl.AutoSize = true;
            CustomersTablelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersTablelbl.Location = new Point(24, 386);
            CustomersTablelbl.Name = "CustomersTablelbl";
            CustomersTablelbl.Size = new Size(157, 25);
            CustomersTablelbl.TabIndex = 18;
            CustomersTablelbl.Text = "Customers Table";
            // 
            // customersDataGridView
            // 
            customersDataGridView.AutoGenerateColumns = false;
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn });
            customersDataGridView.DataSource = customerBindingSource;
            customersDataGridView.Location = new Point(24, 412);
            customersDataGridView.Margin = new Padding(3, 2, 3, 2);
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.RowHeadersWidth = 51;
            customersDataGridView.Size = new Size(372, 151);
            customersDataGridView.TabIndex = 19;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            ageDataGridViewTextBoxColumn.HeaderText = "age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customers.Customer);
            // 
            // Agelbl
            // 
            Agelbl.AutoSize = true;
            Agelbl.Location = new Point(128, 222);
            Agelbl.Name = "Agelbl";
            Agelbl.Size = new Size(28, 15);
            Agelbl.TabIndex = 20;
            Agelbl.Text = "Age";
            // 
            // agenum
            // 
            agenum.Location = new Point(165, 221);
            agenum.Margin = new Padding(3, 2, 3, 2);
            agenum.Name = "agenum";
            agenum.Size = new Size(125, 23);
            agenum.TabIndex = 21;
            // 
            // AddCust
            // 
            AddCust.Location = new Point(173, 274);
            AddCust.Margin = new Padding(3, 2, 3, 2);
            AddCust.Name = "AddCust";
            AddCust.Size = new Size(116, 22);
            AddCust.TabIndex = 22;
            AddCust.Text = "Make Order";
            AddCust.UseVisualStyleBackColor = true;
            AddCust.Click += MakeOrder_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 572);
            Controls.Add(AddCust);
            Controls.Add(agenum);
            Controls.Add(Agelbl);
            Controls.Add(customersDataGridView);
            Controls.Add(CustomersTablelbl);
            Controls.Add(cancelorderbtn);
            Controls.Add(OrderGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(welcomelbl);
            Controls.Add(ProductListBox);
            Controls.Add(Addresstxt);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(Orderlbl);
            Controls.Add(Address);
            Controls.Add(LNamelbl);
            Controls.Add(FNamelbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomersForm";
            Text = "CustomersForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
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
        private CheckedListBox ProductListBox;
        private Label welcomelbl;
        private Label label2;
        private Label label3;
        private DataGridView OrderGridView;
        private Button cancelorderbtn;
        private Label CustomersTablelbl;
        private DataGridView customersDataGridView;
        private Label Agelbl;
        private NumericUpDown agenum;
        private Button AddCust;
        private DataGridViewTextBoxColumn ordersIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productslistDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
    }
}