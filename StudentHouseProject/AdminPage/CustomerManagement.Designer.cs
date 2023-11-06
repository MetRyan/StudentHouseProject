namespace UI.AdminPage
{
    partial class CustomerManagement
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
            lbCustomerId = new Label();
            DateCreated = new Label();
            lbEmail = new Label();
            lbFirstName = new Label();
            lbLastName = new Label();
            lbPhone = new Label();
            lbdateofbirth = new Label();
            lbSex = new Label();
            txtCustomerID = new TextBox();
            txtDateCreated = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            txtLastname = new TextBox();
            txtPhone = new TextBox();
            txtDateOfBirth = new TextBox();
            txtSex = new TextBox();
            dgvlistview = new DataGridView();
            lbSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            cbSearch = new ComboBox();
            label1 = new Label();
            txtAdress = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvlistview).BeginInit();
            SuspendLayout();
            // 
            // lbCustomerId
            // 
            lbCustomerId.AutoSize = true;
            lbCustomerId.Location = new Point(144, 84);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(69, 15);
            lbCustomerId.TabIndex = 0;
            lbCustomerId.Text = "CustomerId";
            // 
            // DateCreated
            // 
            DateCreated.AutoSize = true;
            DateCreated.Location = new Point(144, 138);
            DateCreated.Name = "DateCreated";
            DateCreated.Size = new Size(75, 15);
            DateCreated.TabIndex = 1;
            DateCreated.Text = "Date Created";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(411, 184);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(408, 135);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(61, 15);
            lbFirstName.TabIndex = 3;
            lbFirstName.Text = "FirstName";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(671, 135);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(58, 15);
            lbLastName.TabIndex = 4;
            lbLastName.Text = "Lastname";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(408, 84);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(41, 15);
            lbPhone.TabIndex = 5;
            lbPhone.Text = "Phone";
            // 
            // lbdateofbirth
            // 
            lbdateofbirth.AutoSize = true;
            lbdateofbirth.Location = new Point(671, 84);
            lbdateofbirth.Name = "lbdateofbirth";
            lbdateofbirth.Size = new Size(75, 15);
            lbdateofbirth.TabIndex = 6;
            lbdateofbirth.Text = "Date Of Birth";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(144, 184);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(25, 15);
            lbSex.TabIndex = 7;
            lbSex.Text = "Sex";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(252, 84);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(134, 23);
            txtCustomerID.TabIndex = 8;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Location = new Point(252, 133);
            txtDateCreated.Margin = new Padding(3, 2, 3, 2);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.Size = new Size(134, 23);
            txtDateCreated.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(491, 182);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(491, 133);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(154, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(767, 135);
            txtLastname.Margin = new Padding(3, 2, 3, 2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(291, 23);
            txtLastname.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(491, 84);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(154, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(767, 82);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(291, 23);
            txtDateOfBirth.TabIndex = 14;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(252, 184);
            txtSex.Margin = new Padding(3, 2, 3, 2);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(134, 23);
            txtSex.TabIndex = 15;
            // 
            // dgvlistview
            // 
            dgvlistview.CausesValidation = false;
            dgvlistview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistview.Location = new Point(130, 308);
            dgvlistview.Margin = new Padding(3, 2, 3, 2);
            dgvlistview.Name = "dgvlistview";
            dgvlistview.RowHeadersWidth = 51;
            dgvlistview.RowTemplate.Height = 29;
            dgvlistview.Size = new Size(1060, 218);
            dgvlistview.TabIndex = 16;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(309, 259);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 17;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(390, 260);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(217, 23);
            txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(738, 258);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(441, 502);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(586, 502);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Phone", "Name" });
            cbSearch.Location = new Point(646, 259);
            cbSearch.Margin = new Padding(3, 2, 3, 2);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(64, 23);
            cbSearch.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(671, 182);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 25;
            label1.Text = "Address";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(767, 182);
            txtAdress.Margin = new Padding(3, 2, 3, 2);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(291, 32);
            txtAdress.TabIndex = 26;
            txtAdress.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(440, 27);
            label2.Name = "label2";
            label2.Size = new Size(257, 30);
            label2.TabIndex = 27;
            label2.Text = "Customer Management";
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 658);
            Controls.Add(label2);
            Controls.Add(txtAdress);
            Controls.Add(label1);
            Controls.Add(cbSearch);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(dgvlistview);
            Controls.Add(txtSex);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtPhone);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(txtDateCreated);
            Controls.Add(txtCustomerID);
            Controls.Add(lbSex);
            Controls.Add(lbdateofbirth);
            Controls.Add(lbPhone);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbEmail);
            Controls.Add(DateCreated);
            Controls.Add(lbCustomerId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerManagement";
            Text = "Customer Management";
            Load += frmCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvlistview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCustomerId;
        private Label DateCreated;
        private Label lbEmail;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbPhone;
        private Label lbdateofbirth;
        private Label lbSex;
        private TextBox txtCustomerID;
        private TextBox txtDateCreated;
        private TextBox txtEmail;
        private TextBox txtFirstName;
        private TextBox txtLastname;
        private TextBox txtPhone;
        private TextBox txtDateOfBirth;
        private TextBox txtSex;
        private DataGridView dgvlistview;
        private Label lbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnLoad;
        private ComboBox cbSearch;
        private Label label1;
        private TextBox txtAdress;
        private Label label2;
    }
}