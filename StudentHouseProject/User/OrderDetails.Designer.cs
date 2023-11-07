namespace StudentHouseProject.User
{
    partial class OrderDetails
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
            label1 = new Label();
            lbOrderHistory = new Label();
            dgvOrderDetails = new DataGridView();
            btnReload = new Button();
            dgvViewDetails = new DataGridView();
            ViewDetailsOrder = new Label();
            Address = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtPayment = new TextBox();
            txtOrderDay = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvViewDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 136);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // lbOrderHistory
            // 
            lbOrderHistory.AutoSize = true;
            lbOrderHistory.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderHistory.Location = new Point(511, 27);
            lbOrderHistory.Name = "lbOrderHistory";
            lbOrderHistory.Size = new Size(208, 38);
            lbOrderHistory.TabIndex = 0;
            lbOrderHistory.Text = "Orders History";
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(115, 87);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(937, 268);
            dgvOrderDetails.TabIndex = 2;
            dgvOrderDetails.CellClick += dgvOrderDetails_CellClick;
            dgvOrderDetails.CellContentClick += dgvOrderDetails_CellContentClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(1140, 136);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(165, 49);
            btnReload.TabIndex = 3;
            btnReload.Text = "Load";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // dgvViewDetails
            // 
            dgvViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewDetails.Location = new Point(115, 514);
            dgvViewDetails.Name = "dgvViewDetails";
            dgvViewDetails.RowHeadersWidth = 51;
            dgvViewDetails.RowTemplate.Height = 29;
            dgvViewDetails.Size = new Size(680, 228);
            dgvViewDetails.TabIndex = 4;
            // 
            // ViewDetailsOrder
            // 
            ViewDetailsOrder.AutoSize = true;
            ViewDetailsOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ViewDetailsOrder.Location = new Point(115, 473);
            ViewDetailsOrder.Name = "ViewDetailsOrder";
            ViewDetailsOrder.Size = new Size(262, 38);
            ViewDetailsOrder.TabIndex = 5;
            ViewDetailsOrder.Text = "View Details Order";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(965, 517);
            Address.Name = "Address";
            Address.Size = new Size(62, 20);
            Address.TabIndex = 6;
            Address.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(965, 584);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 7;
            label2.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(965, 652);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 8;
            label3.Text = "Payment Method";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(965, 710);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "OrderDate";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1159, 514);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(282, 42);
            txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(1159, 584);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(1159, 649);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(231, 27);
            txtPayment.TabIndex = 12;
            // 
            // txtOrderDay
            // 
            txtOrderDay.Location = new Point(1159, 707);
            txtOrderDay.Name = "txtOrderDay";
            txtOrderDay.Size = new Size(239, 27);
            txtOrderDay.TabIndex = 13;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1704, 773);
            Controls.Add(txtOrderDay);
            Controls.Add(txtPayment);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Address);
            Controls.Add(ViewDetailsOrder);
            Controls.Add(dgvViewDetails);
            Controls.Add(btnReload);
            Controls.Add(dgvOrderDetails);
            Controls.Add(label1);
            Controls.Add(lbOrderHistory);
            Name = "OrderDetails";
            Text = "OrderDetails";
            Load += OrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvViewDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lbOrderHistory;
        private DataGridView dgvOrderDetails;
        private Button btnReload;
        private DataGridView dgvViewDetails;
        private Label ViewDetailsOrder;
        private Label Address;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtPayment;
        private TextBox txtOrderDay;
    }
}