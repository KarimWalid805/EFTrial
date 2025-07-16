namespace WinFormEF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            categoryBindingSource = new BindingSource(components);
            productsBindingSource = new BindingSource(components);
            buttonSave = new Button();
            categoryDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            categoryBindingSource1 = new BindingSource(components);
            productDataGridView = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            productsBindingSource1 = new BindingSource(components);
            Addbtn = new Button();
            Deletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(749, 409);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.AutoGenerateColumns = false;
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            categoryDataGridView.DataSource = categoryBindingSource1;
            categoryDataGridView.Location = new Point(12, 12);
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.RowHeadersWidth = 51;
            categoryDataGridView.Size = new Size(398, 379);
            categoryDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            dataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(Category);
            // 
            // productDataGridView
            // 
            productDataGridView.AutoGenerateColumns = false;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, CategoryId });
            productDataGridView.DataSource = productsBindingSource1;
            productDataGridView.Location = new Point(416, 12);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.Size = new Size(427, 379);
            productDataGridView.TabIndex = 4;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            dataGridViewTextBoxColumn3.HeaderText = "Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.Width = 125;
            // 
            // productsBindingSource1
            // 
            productsBindingSource1.DataMember = "Products";
            productsBindingSource1.DataSource = categoryBindingSource1;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(649, 409);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(94, 29);
            Addbtn.TabIndex = 5;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(549, 409);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(94, 29);
            Deletebtn.TabIndex = 6;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(Deletebtn);
            Controls.Add(Addbtn);
            Controls.Add(productDataGridView);
            Controls.Add(categoryDataGridView);
            Controls.Add(buttonSave);
            Name = "MainForm";
            Text = "Products and Categories";
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonSave;

        private BindingSource productsBindingSource;
        private BindingSource categoryBindingSource;
       
        private DataGridView categoryDataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource categoryBindingSource1;
        private DataGridView productDataGridView;
        private BindingSource productsBindingSource1;
        private Button Addbtn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn CategoryId;
        private Button Deletebtn;
    }
}
