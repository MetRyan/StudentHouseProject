namespace StudentHouseProject.AdminPage
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
            lbCheckOrder = new Label();
            dgvOrder = new DataGridView();
            btnLoad = new Button();
            dgvCustomer = new DataGridView();
            dgvOrderDetails = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // lbCheckOrder
            // 
            lbCheckOrder.AutoSize = true;
            lbCheckOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbCheckOrder.Location = new Point(463, 62);
            lbCheckOrder.Name = "lbCheckOrder";
            lbCheckOrder.Size = new Size(142, 30);
            lbCheckOrder.TabIndex = 0;
            lbCheckOrder.Text = "Check Order";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(463, 113);
            dgvOrder.Margin = new Padding(3, 2, 3, 2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(844, 164);
            dgvOrder.TabIndex = 1;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick_1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1184, 62);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(123, 37);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(463, 325);
            dgvCustomer.Margin = new Padding(3, 2, 3, 2);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(844, 82);
            dgvCustomer.TabIndex = 3;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(463, 448);
            dgvOrderDetails.Margin = new Padding(3, 2, 3, 2);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(844, 100);
            dgvOrderDetails.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(463, 286);
            label1.Name = "label1";
            label1.Size = new Size(242, 30);
            label1.TabIndex = 5;
            label1.Text = "Customer Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(463, 409);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 6;
            label2.Text = "Product Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(762, 18);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 7;
            label3.Text = "Order Checking";
            // 
            // AdminCheckOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 690);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrderDetails);
            Controls.Add(dgvCustomer);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrder);
            Controls.Add(lbCheckOrder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminCheckOrder";
            Text = "AdminCheckOrder";
            Load += AdminCheckOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCheckOrder;
        private DataGridView dgvOrder;
        private Button btnLoad;
        private DataGridView dgvCustomer;
        private DataGridView dgvOrderDetails;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}