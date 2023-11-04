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
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(239, 629);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(459, 213);
            dgvOrderDetails.TabIndex = 9;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(198, 528);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(960, 68);
            dgvCustomer.TabIndex = 8;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1064, 433);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(198, 129);
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
            lbCheckOrder.Location = new Point(556, 69);
            lbCheckOrder.Name = "lbCheckOrder";
            lbCheckOrder.Size = new Size(178, 38);
            lbCheckOrder.TabIndex = 5;
            lbCheckOrder.Text = "Check Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(198, 472);
            label1.Name = "label1";
            label1.Size = new Size(310, 38);
            label1.TabIndex = 10;
            label1.Text = "Customer Information";
            // 
            // CheckTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 868);
            Controls.Add(label1);
            Controls.Add(dgvOrderDetails);
            Controls.Add(dgvCustomer);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrder);
            Controls.Add(lbCheckOrder);
            Name = "CheckTransactions";
            Text = "CheckTransactions";
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
    }
}