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
            components = new System.ComponentModel.Container();
            catpronavbtn = new Button();
            drivernavbtn = new Button();
            deliverynavbtn = new Button();
            customernavbtn = new Button();
            desclbl = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            CustCount = new TextBox();
            label2 = new Label();
            DriverCount = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            DriverDataGrid = new DataGridView();
            driverIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehicleTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverBindingSource = new BindingSource(components);
            CustomerDataGrid = new DataGridView();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DriverDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // catpronavbtn
            // 
            catpronavbtn.AutoSize = true;
            catpronavbtn.Cursor = Cursors.Hand;
            catpronavbtn.FlatStyle = FlatStyle.Popup;
            catpronavbtn.ForeColor = Color.Red;
            catpronavbtn.Location = new Point(3, 246);
            catpronavbtn.Name = "catpronavbtn";
            catpronavbtn.Size = new Size(188, 64);
            catpronavbtn.TabIndex = 1;
            catpronavbtn.Text = "Categories And Products";
            catpronavbtn.UseVisualStyleBackColor = true;
            catpronavbtn.Click += catpronavbtn_Click;
            // 
            // drivernavbtn
            // 
            drivernavbtn.AutoSize = true;
            drivernavbtn.Cursor = Cursors.Hand;
            drivernavbtn.FlatStyle = FlatStyle.Popup;
            drivernavbtn.Location = new Point(3, 176);
            drivernavbtn.Name = "drivernavbtn";
            drivernavbtn.Size = new Size(188, 64);
            drivernavbtn.TabIndex = 2;
            drivernavbtn.Text = "Driver";
            drivernavbtn.UseVisualStyleBackColor = true;
            drivernavbtn.Click += drivernavbtn_Click;
            // 
            // deliverynavbtn
            // 
            deliverynavbtn.AutoSize = true;
            deliverynavbtn.Cursor = Cursors.Hand;
            deliverynavbtn.FlatStyle = FlatStyle.Popup;
            deliverynavbtn.ForeColor = Color.Maroon;
            deliverynavbtn.Location = new Point(3, 106);
            deliverynavbtn.Name = "deliverynavbtn";
            deliverynavbtn.Size = new Size(188, 64);
            deliverynavbtn.TabIndex = 3;
            deliverynavbtn.Text = "Delivery";
            deliverynavbtn.UseVisualStyleBackColor = true;
            deliverynavbtn.Click += deliverynavbtn_Click;
            // 
            // customernavbtn
            // 
            customernavbtn.AutoSize = true;
            customernavbtn.Cursor = Cursors.Hand;
            customernavbtn.FlatStyle = FlatStyle.Popup;
            customernavbtn.ForeColor = Color.DarkTurquoise;
            customernavbtn.Location = new Point(3, 36);
            customernavbtn.Name = "customernavbtn";
            customernavbtn.Size = new Size(188, 64);
            customernavbtn.TabIndex = 4;
            customernavbtn.Text = "Customer";
            customernavbtn.UseVisualStyleBackColor = true;
            customernavbtn.Click += customernavbtn_Click;
            // 
            // desclbl
            // 
            desclbl.AutoSize = true;
            desclbl.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desclbl.Location = new Point(3, 0);
            desclbl.Name = "desclbl";
            desclbl.Size = new Size(168, 33);
            desclbl.TabIndex = 6;
            desclbl.Text = "Admin Page";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(desclbl);
            flowLayoutPanel1.Controls.Add(customernavbtn);
            flowLayoutPanel1.Controls.Add(deliverynavbtn);
            flowLayoutPanel1.Controls.Add(drivernavbtn);
            flowLayoutPanel1.Controls.Add(catpronavbtn);
            flowLayoutPanel1.Location = new Point(0, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(191, 317);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(743, 512);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 0;
            label1.Text = "Number of Customers:";
            // 
            // CustCount
            // 
            CustCount.Location = new Point(957, 512);
            CustCount.Name = "CustCount";
            CustCount.Size = new Size(59, 27);
            CustCount.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(743, 218);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 0;
            label2.Text = "Number of Drivers:";
            // 
            // DriverCount
            // 
            DriverCount.Location = new Point(926, 218);
            DriverCount.Name = "DriverCount";
            DriverCount.Size = new Size(53, 27);
            DriverCount.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // DriverDataGrid
            // 
            DriverDataGrid.AutoGenerateColumns = false;
            DriverDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DriverDataGrid.Columns.AddRange(new DataGridViewColumn[] { driverIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, vehicleTypeDataGridViewTextBoxColumn });
            DriverDataGrid.DataSource = driverBindingSource;
            DriverDataGrid.Location = new Point(197, 83);
            DriverDataGrid.Name = "DriverDataGrid";
            DriverDataGrid.RowHeadersWidth = 51;
            DriverDataGrid.Size = new Size(527, 291);
            DriverDataGrid.TabIndex = 9;
            // 
            // driverIdDataGridViewTextBoxColumn
            // 
            driverIdDataGridViewTextBoxColumn.DataPropertyName = "DriverId";
            driverIdDataGridViewTextBoxColumn.HeaderText = "DriverId";
            driverIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            driverIdDataGridViewTextBoxColumn.Name = "driverIdDataGridViewTextBoxColumn";
            driverIdDataGridViewTextBoxColumn.Width = 125;
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
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            ageDataGridViewTextBoxColumn.HeaderText = "age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "vehicleType";
            vehicleTypeDataGridViewTextBoxColumn.HeaderText = "vehicleType";
            vehicleTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            vehicleTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverBindingSource
            // 
            driverBindingSource.DataSource = typeof(Drivers.Driver);
            // 
            // CustomerDataGrid
            // 
            CustomerDataGrid.AutoGenerateColumns = false;
            CustomerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGrid.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn1, lastNameDataGridViewTextBoxColumn1, addressDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn1 });
            CustomerDataGrid.DataSource = customerBindingSource;
            CustomerDataGrid.Location = new Point(197, 392);
            CustomerDataGrid.Name = "CustomerDataGrid";
            CustomerDataGrid.RowHeadersWidth = 51;
            CustomerDataGrid.Size = new Size(527, 273);
            CustomerDataGrid.TabIndex = 10;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            firstNameDataGridViewTextBoxColumn1.DataPropertyName = "firstName";
            firstNameDataGridViewTextBoxColumn1.HeaderText = "firstName";
            firstNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            firstNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            lastNameDataGridViewTextBoxColumn1.DataPropertyName = "lastName";
            lastNameDataGridViewTextBoxColumn1.HeaderText = "lastName";
            lastNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            lastNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            ageDataGridViewTextBoxColumn1.DataPropertyName = "age";
            ageDataGridViewTextBoxColumn1.HeaderText = "age";
            ageDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            ageDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customers.Customer);
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 677);
            Controls.Add(label1);
            Controls.Add(CustCount);
            Controls.Add(CustomerDataGrid);
            Controls.Add(label2);
            Controls.Add(DriverCount);
            Controls.Add(DriverDataGrid);
            Controls.Add(flowLayoutPanel1);
            Name = "StartForm";
            Text = "StartForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DriverDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox WelcomeText;
        private Button catpronavbtn;
        private Button drivernavbtn;
        private Button deliverynavbtn;
        private Button customernavbtn;
        private Label desclbl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private DataGridView DriverDataGrid;
        private DataGridViewTextBoxColumn driverIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private BindingSource driverBindingSource;
        private DataGridView CustomerDataGrid;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private BindingSource customerBindingSource;
        private TextBox CustCount;
        private TextBox DriverCount;
    }
}