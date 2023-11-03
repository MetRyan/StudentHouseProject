namespace StudentHouseProject.AdminAPage
{
    partial class AdminCheckOrder
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
            lbOrderList = new Label();
            dgvOrder = new DataGridView();
            btnLoad = new Button();
            dgvOrderDetails = new DataGridView();
            dgvCustomer = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // lbOrderList
            // 
            lbOrderList.AutoSize = true;
            lbOrderList.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderList.Location = new Point(672, 55);
            lbOrderList.Name = "lbOrderList";
            lbOrderList.Size = new Size(157, 41);
            lbOrderList.TabIndex = 0;
            lbOrderList.Text = "Order List";
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(473, 115);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(558, 263);
            dgvOrder.TabIndex = 1;
            dgvOrder.CellClick += dgvOrder_CellClick;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1093, 189);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(163, 50);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AllowUserToResizeColumns = false;
            dgvOrderDetails.AllowUserToResizeRows = false;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(872, 475);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(558, 263);
            dgvOrderDetails.TabIndex = 3;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AllowUserToResizeColumns = false;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(106, 475);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(708, 63);
            dgvCustomer.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(872, 425);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 5;
            label1.Text = "OrderDetails";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(106, 425);
            label2.Name = "label2";
            label2.Size = new Size(193, 41);
            label2.TabIndex = 6;
            label2.Text = "CustomerInf";
            // 
            // AdminCheckOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 780);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCustomer);
            Controls.Add(dgvOrderDetails);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrder);
            Controls.Add(lbOrderList);
            Name = "AdminCheckOrder";
            Text = "AdminCheckOrder";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderList;
        private DataGridView dgvOrder;
        private Button btnLoad;
        private DataGridView dgvOrderDetails;
        private DataGridView dgvCustomer;
        private Label label1;
        private Label label2;
    }
}