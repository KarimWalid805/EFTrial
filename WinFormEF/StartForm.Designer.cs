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
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
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
            flowLayoutPanel1.Size = new Size(191, 501);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Location = new Point(192, 65);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(778, 318);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 0;
            label1.Text = "Number of Customers:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 378);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "StartForm";
            Text = "StartForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox WelcomeText;
        private Button catpronavbtn;
        private Button drivernavbtn;
        private Button deliverynavbtn;
        private Button customernavbtn;
        private Label desclbl;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
    }
}