using WinFormEF.CatPro;

namespace WinFormEF
{
    partial class CatProForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.AutoGenerateColumns = false;
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            categoryDataGridView.DataSource = categoryBindingSource1;
            categoryDataGridView.Location = new Point(10, 87);
            categoryDataGridView.Margin = new Padding(3, 2, 3, 2);
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.RowHeadersWidth = 51;
            categoryDataGridView.Size = new Size(348, 284);
            categoryDataGridView.TabIndex = 3;
            categoryDataGridView.CellContentClick += categoryDataGridView_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            dataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
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
            productDataGridView.Location = new Point(435, 88);
            productDataGridView.Margin = new Padding(3, 2, 3, 2);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.Size = new Size(374, 284);
            productDataGridView.TabIndex = 4;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
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
            Addbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Addbtn.ForeColor = Color.FromArgb(0, 192, 0);
            Addbtn.Location = new Point(606, 376);
            Addbtn.Margin = new Padding(3, 2, 3, 2);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(111, 22);
            Addbtn.TabIndex = 5;
            Addbtn.Text = "Add Product";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Deletebtn.ForeColor = Color.Red;
            Deletebtn.Location = new Point(489, 376);
            Deletebtn.Margin = new Padding(3, 2, 3, 2);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(111, 22);
            Deletebtn.TabIndex = 6;
            Deletebtn.Text = "Delete Product";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(41, 376);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 22);
            button1.TabIndex = 9;
            button1.Text = "Delete Category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 192, 0);
            button2.Location = new Point(168, 376);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 22);
            button2.TabIndex = 8;
            button2.Text = "Add Category";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(334, 391);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(126, 28);
            button3.TabIndex = 7;
            button3.Text = "Save Changes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 62);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(157, 25);
            label1.TabIndex = 10;
            label1.Text = "Categories Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(567, 62);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(143, 25);
            label2.TabIndex = 11;
            label2.Text = "Products Table";
            // 
            // CatProForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 430);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(Deletebtn);
            Controls.Add(Addbtn);
            Controls.Add(productDataGridView);
            Controls.Add(categoryDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CatProForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products and Categories";
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;

        private BindingSource productsBindingSource;
        private BindingSource categoryBindingSource;
       
        private DataGridView categoryDataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource1;
        private DataGridView productDataGridView;
        private BindingSource productsBindingSource1;
        private Button Addbtn;
        private DataGridViewTextBoxColumn Category;
        private Button Deletebtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn CategoryId;
    }
}
