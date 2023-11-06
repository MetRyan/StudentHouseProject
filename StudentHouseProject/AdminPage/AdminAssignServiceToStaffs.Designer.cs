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
            label1.Location = new Point(724, 18);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 1;
            label1.Text = "Assign Staff to Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(591, 79);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 2;
            label2.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(591, 130);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Staff ID";
            label3.Click += label3_Click;
            // 
            // cbStaff
            // 
            cbStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(709, 124);
            cbStaff.Margin = new Padding(3, 2, 3, 2);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(262, 23);
            cbStaff.TabIndex = 12;
            cbStaff.SelectedIndexChanged += cbStaff_SelectedIndexChanged;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssign.Location = new Point(1015, 130);
            btnAssign.Margin = new Padding(3, 2, 3, 2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(69, 69);
            btnAssign.TabIndex = 6;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click_1;
            // 
            // lbWorkDate
            // 
            lbWorkDate.AutoSize = true;
            lbWorkDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbWorkDate.Location = new Point(591, 177);
            lbWorkDate.Name = "lbWorkDate";
            lbWorkDate.Size = new Size(64, 15);
            lbWorkDate.TabIndex = 9;
            lbWorkDate.Text = "Work Date";
            // 
            // txtWorkDate
            // 
            txtWorkDate.Location = new Point(709, 174);
            txtWorkDate.Mask = "00/00/0000";
            txtWorkDate.Name = "txtWorkDate";
            txtWorkDate.Size = new Size(262, 23);
            txtWorkDate.TabIndex = 10;
            txtWorkDate.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(591, 79);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 11;
            label4.Text = "Order ID";
            // 
            // cbOrderId
            // 
            cbOrderId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrderId.FormattingEnabled = true;
            cbOrderId.Location = new Point(709, 76);
            cbOrderId.Margin = new Padding(3, 2, 3, 2);
            cbOrderId.Name = "cbOrderId";
            cbOrderId.Size = new Size(262, 23);
            cbOrderId.TabIndex = 12;
            cbOrderId.SelectedIndexChanged += cbOrderId_SelectedIndexChanged;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(483, 248);
            dgvStaff.Margin = new Padding(3, 2, 3, 2);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 29;
            dgvStaff.Size = new Size(761, 76);
            dgvStaff.TabIndex = 13;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(483, 379);
            dgvOrder.Margin = new Padding(3, 2, 3, 2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(761, 219);
            dgvOrder.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(483, 216);
            label5.Name = "label5";
            label5.Size = new Size(59, 30);
            label5.TabIndex = 15;
            label5.Text = "Staff";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(483, 347);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 16;
            label6.Text = "Order";
            // 
            // AdminAssignServiceToStaffs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 634);
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
            Margin = new Padding(3, 2, 3, 2);
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