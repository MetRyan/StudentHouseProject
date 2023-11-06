namespace UI.AdminPage
{
    partial class StaffManagement
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
            lbStaffId = new Label();
            lbStaffName = new Label();
            lbEmail = new Label();
            lbPhone = new Label();
            lbdob = new Label();
            lbSex = new Label();
            lbStatus = new Label();
            txtStaffId = new TextBox();
            txtStaffName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtStatus = new TextBox();
            txtdob = new TextBox();
            txtSex = new TextBox();
            label2 = new Label();
            cbSearch = new ComboBox();
            dgv = new DataGridView();
            btnSearch = new Button();
            btnLoad = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtServiceId = new TextBox();
            lbServiceId = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 3);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 0;
            label1.Text = " ";
            // 
            // lbStaffId
            // 
            lbStaffId.AutoSize = true;
            lbStaffId.Location = new Point(43, 73);
            lbStaffId.Name = "lbStaffId";
            lbStaffId.Size = new Size(44, 15);
            lbStaffId.TabIndex = 1;
            lbStaffId.Text = "Staff Id";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.Location = new Point(40, 104);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(66, 15);
            lbStaffName.TabIndex = 2;
            lbStaffName.Text = "Staff Name";
            lbStaffName.Click += label3_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(40, 140);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(326, 70);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(41, 15);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "Phone";
            // 
            // lbdob
            // 
            lbdob.AutoSize = true;
            lbdob.Location = new Point(326, 104);
            lbdob.Name = "lbdob";
            lbdob.Size = new Size(75, 15);
            lbdob.TabIndex = 5;
            lbdob.Text = "Date Of Birth";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(41, 176);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(25, 15);
            lbSex.TabIndex = 6;
            lbSex.Text = "Sex";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(327, 176);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 7;
            lbStatus.Text = "Status";
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new Point(144, 68);
            txtStaffId.Margin = new Padding(3, 2, 3, 2);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new Size(149, 23);
            txtStaffId.TabIndex = 8;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(144, 101);
            txtStaffName.Margin = new Padding(3, 2, 3, 2);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(149, 23);
            txtStaffName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 136);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(149, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(430, 68);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 23);
            txtPhone.TabIndex = 11;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(430, 174);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(227, 23);
            txtStatus.TabIndex = 12;
            // 
            // txtdob
            // 
            txtdob.Location = new Point(430, 104);
            txtdob.Margin = new Padding(3, 2, 3, 2);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(227, 23);
            txtdob.TabIndex = 13;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(144, 173);
            txtSex.Margin = new Padding(3, 2, 3, 2);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(149, 23);
            txtSex.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 213);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 16;
            label2.Text = "Search Status";
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "true", "false" });
            cbSearch.Location = new Point(144, 213);
            cbSearch.Margin = new Padding(3, 2, 3, 2);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(149, 23);
            cbSearch.TabIndex = 17;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(51, 271);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(613, 129);
            dgv.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(317, 213);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(113, 404);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(249, 404);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(377, 404);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(517, 404);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtServiceId
            // 
            txtServiceId.Location = new Point(430, 136);
            txtServiceId.Margin = new Padding(3, 2, 3, 2);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new Size(227, 23);
            txtServiceId.TabIndex = 24;
            // 
            // lbServiceId
            // 
            lbServiceId.AutoSize = true;
            lbServiceId.Location = new Point(326, 141);
            lbServiceId.Name = "lbServiceId";
            lbServiceId.Size = new Size(54, 15);
            lbServiceId.TabIndex = 25;
            lbServiceId.Text = "ServiceId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(249, 20);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 26;
            label3.Text = "Staff Management";
            // 
            // StaffManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 455);
            Controls.Add(label3);
            Controls.Add(lbServiceId);
            Controls.Add(txtServiceId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(dgv);
            Controls.Add(cbSearch);
            Controls.Add(label2);
            Controls.Add(txtSex);
            Controls.Add(txtdob);
            Controls.Add(txtStatus);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffId);
            Controls.Add(lbStatus);
            Controls.Add(lbSex);
            Controls.Add(lbdob);
            Controls.Add(lbPhone);
            Controls.Add(lbEmail);
            Controls.Add(lbStaffName);
            Controls.Add(lbStaffId);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffManagement";
            Text = "Staff Management";
            Load += StaffManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbStaffId;
        private Label lbStaffName;
        private Label lbEmail;
        private Label lbPhone;
        private Label lbdob;
        private Label lbSex;
        private Label lbStatus;
        private TextBox txtStaffId;
        private TextBox txtStaffName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtStatus;
        private TextBox txtdob;
        private TextBox txtSex;
        private Label label2;
        private ComboBox cbSearch;
        private DataGridView dgv;
        private Button btnSearch;
        private Button btnLoad;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtServiceId;
        private Label lbServiceId;
        private Label label3;
    }
}