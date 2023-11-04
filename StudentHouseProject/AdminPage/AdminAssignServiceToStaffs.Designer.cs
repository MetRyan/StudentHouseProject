namespace StudentHouseProject.AdminAPage
{
    partial class AdminAssignServiceToStaffs
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
            label2 = new Label();
            label3 = new Label();
            cbStaff = new ComboBox();
            btnAssign = new Button();
            lbWorkDate = new Label();
            txtWorkDate = new MaskedTextBox();
            label4 = new Label();
            cbOrderId = new ComboBox();
            dgvStaff = new DataGridView();
            dgvOrder = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 27);
            label1.Name = "label1";
            label1.Size = new Size(283, 38);
            label1.TabIndex = 1;
            label1.Text = "Assign Staff to Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 108);
            label2.Name = "label2";
            label2.Size = new Size(13, 20);
            label2.TabIndex = 2;
            label2.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(169, 176);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Staff ID";
            label3.Click += label3_Click;
            // 
            // cbStaff
            // 
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(304, 168);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(299, 28);
            cbStaff.TabIndex = 12;
            cbStaff.SelectedIndexChanged += cbStaff_SelectedIndexChanged;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssign.Location = new Point(434, 309);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(143, 47);
            btnAssign.TabIndex = 6;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click_1;
            // 
            // lbWorkDate
            // 
            lbWorkDate.AutoSize = true;
            lbWorkDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbWorkDate.Location = new Point(169, 239);
            lbWorkDate.Name = "lbWorkDate";
            lbWorkDate.Size = new Size(82, 20);
            lbWorkDate.TabIndex = 9;
            lbWorkDate.Text = "Work Date";
            // 
            // txtWorkDate
            // 
            txtWorkDate.Location = new Point(304, 235);
            txtWorkDate.Margin = new Padding(3, 4, 3, 4);
            txtWorkDate.Mask = "00/00/0000";
            txtWorkDate.Name = "txtWorkDate";
            txtWorkDate.Size = new Size(299, 27);
            txtWorkDate.TabIndex = 10;
            txtWorkDate.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(169, 108);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 11;
            label4.Text = "Order ID";
            // 
            // cbOrderId
            // 
            cbOrderId.FormattingEnabled = true;
            cbOrderId.Location = new Point(304, 104);
            cbOrderId.Name = "cbOrderId";
            cbOrderId.Size = new Size(299, 28);
            cbOrderId.TabIndex = 12;
            cbOrderId.SelectedIndexChanged += cbOrderId_SelectedIndexChanged;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(35, 423);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 29;
            dgvStaff.Size = new Size(882, 79);
            dgvStaff.TabIndex = 13;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(35, 547);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(882, 160);
            dgvOrder.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 364);
            label5.Name = "label5";
            label5.Size = new Size(101, 38);
            label5.TabIndex = 15;
            label5.Text = "StaffId";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 504);
            label6.Name = "label6";
            label6.Size = new Size(115, 38);
            label6.TabIndex = 16;
            label6.Text = "OrderId";
            // 
            // AdminAssignServiceToStaffs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 845);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvOrder);
            Controls.Add(dgvStaff);
            Controls.Add(cbOrderId);
            Controls.Add(label4);
            Controls.Add(txtWorkDate);
            Controls.Add(lbWorkDate);
            Controls.Add(btnAssign);
            Controls.Add(cbStaff);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminAssignServiceToStaffs";
            Text = "Assign Staff to the Service";
            Load += AdminAssignServiceToStaffs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbStaff;
        private Button btnAssign;
        private Label lbWorkDate;
        private MaskedTextBox txtWorkDate;
        private Label label4;
        private ComboBox cbOrderId;
        private DataGridView dgvStaff;
        private DataGridView dgvOrder;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}