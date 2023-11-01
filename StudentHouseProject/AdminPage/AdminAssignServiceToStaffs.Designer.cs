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
            txtOrderId = new TextBox();
            label3 = new Label();
            cbStaff = new ComboBox();
            btnAssign = new Button();
            btnReturn = new Button();
            lbWorkDate = new Label();
            txtWorkDate = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 20);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 1;
            label1.Text = "Assign Staff to Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(148, 81);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Order ID";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(266, 79);
            txtOrderId.Margin = new Padding(3, 2, 3, 2);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(262, 23);
            txtOrderId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(148, 132);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Staff ID";
            label3.Click += label3_Click;
            // 
            // cbStaff
            // 
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(266, 126);
            cbStaff.Margin = new Padding(3, 2, 3, 2);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(262, 23);
            cbStaff.TabIndex = 5;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssign.Location = new Point(380, 232);
            btnAssign.Margin = new Padding(3, 2, 3, 2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(125, 35);
            btnAssign.TabIndex = 6;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(526, 232);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(125, 35);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // lbWorkDate
            // 
            lbWorkDate.AutoSize = true;
            lbWorkDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbWorkDate.Location = new Point(148, 179);
            lbWorkDate.Name = "lbWorkDate";
            lbWorkDate.Size = new Size(64, 15);
            lbWorkDate.TabIndex = 9;
            lbWorkDate.Text = "Work Date";
            // 
            // txtWorkDate
            // 
            txtWorkDate.Location = new Point(266, 176);
            txtWorkDate.Mask = "00/00/0000";
            txtWorkDate.Name = "txtWorkDate";
            txtWorkDate.Size = new Size(262, 23);
            txtWorkDate.TabIndex = 10;
            txtWorkDate.ValidatingType = typeof(DateTime);
            // 
            // AdminAssignServiceToStaffs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 320);
            Controls.Add(txtWorkDate);
            Controls.Add(lbWorkDate);
            Controls.Add(btnReturn);
            Controls.Add(btnAssign);
            Controls.Add(cbStaff);
            Controls.Add(label3);
            Controls.Add(txtOrderId);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminAssignServiceToStaffs";
            Text = "Assign Staff to the Service";
            Load += AdminAssignServiceToStaffs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOrderId;
        private Label label3;
        private ComboBox cbStaff;
        private Button btnAssign;
        private Button btnReturn;
        private Label lbWorkDate;
        private MaskedTextBox txtWorkDate;
    }
}