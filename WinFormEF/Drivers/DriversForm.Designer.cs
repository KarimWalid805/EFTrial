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
            DriverGridView = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            Addbtn = new Button();
            Removebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Agetxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DriverGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // driverFNamelbl
            // 
            driverFNamelbl.AutoSize = true;
            driverFNamelbl.Location = new Point(10, 12);
            driverFNamelbl.Name = "driverFNamelbl";
            driverFNamelbl.Size = new Size(133, 20);
            driverFNamelbl.TabIndex = 0;
            driverFNamelbl.Text = "Driver's First Name";
            // 
            // driverLNamelbl
            // 
            driverLNamelbl.AutoSize = true;
            driverLNamelbl.Location = new Point(10, 55);
            driverLNamelbl.Name = "driverLNamelbl";
            driverLNamelbl.Size = new Size(132, 20);
            driverLNamelbl.TabIndex = 1;
            driverLNamelbl.Text = "Driver's Last Name";
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(149, 12);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(125, 27);
            FirstNametxt.TabIndex = 2;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(149, 55);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(125, 27);
            LastNametxt.TabIndex = 3;
            // 
            // vehicleTypelbl
            // 
            vehicleTypelbl.AutoSize = true;
            vehicleTypelbl.Location = new Point(52, 146);
            vehicleTypelbl.Name = "vehicleTypelbl";
            vehicleTypelbl.Size = new Size(91, 20);
            vehicleTypelbl.TabIndex = 4;
            vehicleTypelbl.Text = "Vehicle Type";
            // 
            // VehicleBox
            // 
            VehicleBox.FormattingEnabled = true;
            VehicleBox.Location = new Point(149, 143);
            VehicleBox.Name = "VehicleBox";
            VehicleBox.Size = new Size(125, 28);
            VehicleBox.TabIndex = 5;
            // 
            // Agelbl
            // 
            Agelbl.AutoSize = true;
            Agelbl.Location = new Point(106, 101);
            Agelbl.Name = "Agelbl";
            Agelbl.Size = new Size(36, 20);
            Agelbl.TabIndex = 6;
            Agelbl.Text = "Age";
            // 
            // Agetxt
            // 
            Agetxt.Location = new Point(149, 101);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(125, 27);
            Agetxt.TabIndex = 7;
            // 
            // DriverGridView
            // 
            DriverGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DriverGridView.Location = new Point(12, 457);
            DriverGridView.Name = "DriverGridView";
            DriverGridView.RowHeadersWidth = 51;
            DriverGridView.Size = new Size(429, 188);
            DriverGridView.TabIndex = 8;
            DriverGridView.Tag = "Driver";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // Addbtn
            // 
            Addbtn.ForeColor = Color.FromArgb(0, 192, 0);
            Addbtn.Location = new Point(311, 20);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(130, 29);
            Addbtn.TabIndex = 9;
            Addbtn.Text = "Choose Order";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Removebtn
            // 
            Removebtn.ForeColor = Color.Red;
            Removebtn.Location = new Point(345, 422);
            Removebtn.Name = "Removebtn";
            Removebtn.Size = new Size(94, 29);
            Removebtn.TabIndex = 10;
            Removebtn.Text = "Remove";
            Removebtn.UseVisualStyleBackColor = true;
            Removebtn.Click += Removebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 190);
            label1.Name = "label1";
            label1.Size = new Size(274, 20);
            label1.TabIndex = 13;
            label1.Text = "Choose which order you want to deliver:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 648);
            label2.Name = "label2";
            label2.Size = new Size(380, 20);
            label2.TabIndex = 14;
            label2.Text = "(Make sure to save your edit by clicking the edit button.)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 423);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 15;
            label3.Text = "All Drivers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 383);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 16;
            label4.Text = "Admin Controls";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(429, 150);
            dataGridView1.TabIndex = 17;
            // 
            // DriversForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 681);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Removebtn);
            Controls.Add(Addbtn);
            Controls.Add(DriverGridView);
            Controls.Add(Agetxt);
            Controls.Add(Agelbl);
            Controls.Add(VehicleBox);
            Controls.Add(vehicleTypelbl);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(driverLNamelbl);
            Controls.Add(driverFNamelbl);
            Name = "DriversForm";
            Text = "Drivers";
            ((System.ComponentModel.ISupportInitialize)Agetxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DriverGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView DriverGridView;
        private BindingSource categoryBindingSource;
        private Button Addbtn;
        private Button Removebtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}