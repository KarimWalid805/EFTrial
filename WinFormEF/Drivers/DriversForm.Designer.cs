using WinFormEF.CatPro;

namespace WinFormEF
{
    partial class DriversForm
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
            driverFNamelbl = new Label();
            driverLNamelbl = new Label();
            FirstNametxt = new TextBox();
            LastNametxt = new TextBox();
            vehicleTypelbl = new Label();
            VehicleBox = new ComboBox();
            Agelbl = new Label();
            Agetxt = new NumericUpDown();
            categoryBindingSource = new BindingSource(components);
            Addbtn = new Button();
            label1 = new Label();
            OrderGridView = new DataGridView();
            ordersIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productslistDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordersBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            usernametxt = new TextBox();
            deliveryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)Agetxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deliveryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // driverFNamelbl
            // 
            driverFNamelbl.AutoSize = true;
            driverFNamelbl.Location = new Point(28, 90);
            driverFNamelbl.Name = "driverFNamelbl";
            driverFNamelbl.Size = new Size(106, 15);
            driverFNamelbl.TabIndex = 0;
            driverFNamelbl.Text = "Driver's First Name";
            // 
            // driverLNamelbl
            // 
            driverLNamelbl.AutoSize = true;
            driverLNamelbl.Location = new Point(28, 122);
            driverLNamelbl.Name = "driverLNamelbl";
            driverLNamelbl.Size = new Size(105, 15);
            driverLNamelbl.TabIndex = 1;
            driverLNamelbl.Text = "Driver's Last Name";
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(149, 90);
            FirstNametxt.Margin = new Padding(3, 2, 3, 2);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(146, 23);
            FirstNametxt.TabIndex = 2;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(149, 122);
            LastNametxt.Margin = new Padding(3, 2, 3, 2);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(146, 23);
            LastNametxt.TabIndex = 3;
            // 
            // vehicleTypelbl
            // 
            vehicleTypelbl.AutoSize = true;
            vehicleTypelbl.Location = new Point(64, 190);
            vehicleTypelbl.Name = "vehicleTypelbl";
            vehicleTypelbl.Size = new Size(72, 15);
            vehicleTypelbl.TabIndex = 4;
            vehicleTypelbl.Text = "Vehicle Type";
            // 
            // VehicleBox
            // 
            VehicleBox.FormattingEnabled = true;
            VehicleBox.Location = new Point(149, 188);
            VehicleBox.Margin = new Padding(3, 2, 3, 2);
            VehicleBox.Name = "VehicleBox";
            VehicleBox.Size = new Size(146, 23);
            VehicleBox.TabIndex = 5;
            // 
            // Agelbl
            // 
            Agelbl.AutoSize = true;
            Agelbl.Location = new Point(112, 156);
            Agelbl.Name = "Agelbl";
            Agelbl.Size = new Size(28, 15);
            Agelbl.TabIndex = 6;
            Agelbl.Text = "Age";
            // 
            // Agetxt
            // 
            Agetxt.Location = new Point(149, 156);
            Agetxt.Margin = new Padding(3, 2, 3, 2);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(145, 23);
            Agetxt.TabIndex = 7;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // Addbtn
            // 
            Addbtn.ForeColor = Color.FromArgb(0, 192, 0);
            Addbtn.Location = new Point(145, 225);
            Addbtn.Margin = new Padding(3, 2, 3, 2);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(150, 22);
            Addbtn.TabIndex = 9;
            Addbtn.Text = "Choose Order";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 73);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 13;
            label1.Text = "Choose which order you want to deliver:";
            // 
            // OrderGridView
            // 
            OrderGridView.AutoGenerateColumns = false;
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Columns.AddRange(new DataGridViewColumn[] { ordersIdDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, productslistDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn });
            OrderGridView.DataSource = ordersBindingSource;
            OrderGridView.Location = new Point(315, 90);
            OrderGridView.Margin = new Padding(3, 2, 3, 2);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.Size = new Size(429, 329);
            OrderGridView.TabIndex = 17;
            // 
            // ordersIdDataGridViewTextBoxColumn
            // 
            ordersIdDataGridViewTextBoxColumn.DataPropertyName = "OrdersId";
            ordersIdDataGridViewTextBoxColumn.HeaderText = "OrdersId";
            ordersIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ordersIdDataGridViewTextBoxColumn.Name = "ordersIdDataGridViewTextBoxColumn";
            ordersIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
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
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataSource = typeof(Customers.Orders);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(812, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.DarkSlateGray;
            usernametxt.BorderStyle = BorderStyle.None;
            usernametxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            usernametxt.ForeColor = SystemColors.MenuBar;
            usernametxt.Location = new Point(849, 29);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(181, 29);
            usernametxt.TabIndex = 26;
            // 
            // deliveryBindingSource
            // 
            deliveryBindingSource.DataSource = typeof(Drivers.Delivery);
            // 
            // DriversForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 637);
            Controls.Add(usernametxt);
            Controls.Add(pictureBox1);
            Controls.Add(OrderGridView);
            Controls.Add(label1);
            Controls.Add(Addbtn);
            Controls.Add(Agetxt);
            Controls.Add(Agelbl);
            Controls.Add(VehicleBox);
            Controls.Add(vehicleTypelbl);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(driverLNamelbl);
            Controls.Add(driverFNamelbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DriversForm";
            Text = "Drivers";
            ((System.ComponentModel.ISupportInitialize)Agetxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)deliveryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label driverFNamelbl;
        private Label driverLNamelbl;
        private TextBox FirstNametxt;
        private TextBox LastNametxt;
        private Label vehicleTypelbl;
        private ComboBox VehicleBox;
        private Label Agelbl;
        private NumericUpDown Agetxt;
        private BindingSource categoryBindingSource;
        private Button Addbtn;
        private Label label1;
        private DataGridView OrderGridView;
        private DataGridViewTextBoxColumn ordersIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productslistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private BindingSource ordersBindingSource;
        private PictureBox pictureBox1;
        private TextBox usernametxt;
        private BindingSource deliveryBindingSource;
    }
}