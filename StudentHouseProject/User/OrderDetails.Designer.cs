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
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 136);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // lbOrderHistory
            // 
            lbOrderHistory.AutoSize = true;
            lbOrderHistory.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderHistory.Location = new Point(289, 32);
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
            dgvOrderDetails.Size = new Size(541, 274);
            dgvOrderDetails.TabIndex = 2;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(257, 389);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(94, 29);
            btnReload.TabIndex = 3;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(418, 389);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnReload);
            Controls.Add(dgvOrderDetails);
            Controls.Add(label1);
            Controls.Add(lbOrderHistory);
            Name = "OrderDetails";
            Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lbOrderHistory;
        private DataGridView dgvOrderDetails;
        private Button btnReload;
        private Button btnReturn;
    }
}