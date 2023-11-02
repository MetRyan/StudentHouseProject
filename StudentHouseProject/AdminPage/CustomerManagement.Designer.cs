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
            btnCreate = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            cbSearch = new ComboBox();
            label1 = new Label();
            txtAdress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvlistview).BeginInit();
            SuspendLayout();
            // 
            // lbCustomerId
            // 
            lbCustomerId.AutoSize = true;
            lbCustomerId.Location = new Point(176, 112);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(85, 20);
            lbCustomerId.TabIndex = 0;
            lbCustomerId.Text = "CustomerId";
            // 
            // DateCreated
            // 
            DateCreated.AutoSize = true;
            DateCreated.Location = new Point(176, 177);
            DateCreated.Name = "DateCreated";
            DateCreated.Size = new Size(97, 20);
            DateCreated.TabIndex = 1;
            DateCreated.Text = "Date Created";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(466, 249);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(466, 180);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(76, 20);
            lbFirstName.TabIndex = 3;
            lbFirstName.Text = "FirstName";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(767, 180);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(72, 20);
            lbLastName.TabIndex = 4;
            lbLastName.Text = "Lastname";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(459, 112);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 5;
            lbPhone.Text = "Phone";
            // 
            // lbdateofbirth
            // 
            lbdateofbirth.AutoSize = true;
            lbdateofbirth.Location = new Point(757, 112);
            lbdateofbirth.Name = "lbdateofbirth";
            lbdateofbirth.Size = new Size(96, 20);
            lbdateofbirth.TabIndex = 6;
            lbdateofbirth.Text = "Date Of Birth";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(176, 242);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(32, 20);
            lbSex.TabIndex = 7;
            lbSex.Text = "Sex";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(300, 112);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(153, 27);
            txtCustomerID.TabIndex = 8;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Location = new Point(300, 177);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.Size = new Size(153, 27);
            txtDateCreated.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(561, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(561, 177);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(877, 180);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(332, 27);
            txtLastname.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(561, 112);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(176, 27);
            txtPhone.TabIndex = 13;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(877, 112);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(332, 27);
            txtDateOfBirth.TabIndex = 14;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(300, 242);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(153, 27);
            txtSex.TabIndex = 15;
            // 
            // dgvlistview
            // 
            dgvlistview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistview.Location = new Point(149, 411);
            dgvlistview.Name = "dgvlistview";
            dgvlistview.RowHeadersWidth = 51;
            dgvlistview.RowTemplate.Height = 29;
            dgvlistview.Size = new Size(923, 218);
            dgvlistview.TabIndex = 16;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(181, 344);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 17;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(274, 345);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 27);
            txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(671, 343);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(322, 667);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(458, 668);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(591, 667);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(726, 668);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Phone", "Name" });
            cbSearch.Location = new Point(566, 344);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(73, 28);
            cbSearch.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(767, 252);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 25;
            label1.Text = "Address";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(877, 242);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(332, 42);
            txtAdress.TabIndex = 26;
            txtAdress.TextChanged += textBox1_TextChanged;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 878);
            Controls.Add(txtAdress);
            Controls.Add(label1);
            Controls.Add(cbSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(btnCreate);
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
            Name = "CustomerManagement";
            Text = "CustomerManagement";
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
        private Button btnCreate;
        private Button btnLoad;
        private Button btnUpdate;
        private ComboBox cbSearch;
        private Label label1;
        private TextBox txtAdress;
    }
}