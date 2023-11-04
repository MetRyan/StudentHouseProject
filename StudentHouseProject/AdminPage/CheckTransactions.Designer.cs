namespace StudentHouseProject.AdminPage
{
    partial class CheckTransactions
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
            dgvOrderDetails = new DataGridView();
            dgvCustomer = new DataGridView();
            btnLoad = new Button();
            dgvOrder = new DataGridView();
            lbCheckOrder = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(185, 611);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(960, 213);
            dgvOrderDetails.TabIndex = 9;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(185, 468);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(960, 68);
            dgvCustomer.TabIndex = 8;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1026, 93);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(119, 42);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(185, 141);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(960, 259);
            dgvOrder.TabIndex = 6;
            dgvOrder.CellClick += dgvOrder_CellClick;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick_2;
            // 
            // lbCheckOrder
            // 
            lbCheckOrder.AutoSize = true;
            lbCheckOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbCheckOrder.Location = new Point(565, 34);
            lbCheckOrder.Name = "lbCheckOrder";
            lbCheckOrder.Size = new Size(178, 38);
            lbCheckOrder.TabIndex = 5;
            lbCheckOrder.Text = "Check Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 416);
            label1.Name = "label1";
            label1.Size = new Size(310, 38);
            label1.TabIndex = 10;
            label1.Text = "Customer Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(185, 555);
            label2.Name = "label2";
            label2.Size = new Size(297, 41);
            label2.TabIndex = 11;
            label2.Text = "Service Information";
            // 
            // CheckTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 868);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrderDetails);
            Controls.Add(dgvCustomer);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrder);
            Controls.Add(lbCheckOrder);
            Name = "CheckTransactions";
            Text = "Check Order";
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetails;
        private DataGridView dgvCustomer;
        private Button btnLoad;
        private DataGridView dgvOrder;
        private Label lbCheckOrder;
        private Label label1;
        private Label label2;
    }
}