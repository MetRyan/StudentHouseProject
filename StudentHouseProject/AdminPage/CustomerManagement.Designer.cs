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
            lbCustomerId.Location = new Point(444, 112);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(89, 20);
            lbCustomerId.TabIndex = 0;
            lbCustomerId.Text = "Customer Id";
            // 
            // DateCreated
            // 
            DateCreated.AutoSize = true;
            DateCreated.Location = new Point(444, 194);
            DateCreated.Name = "DateCreated";
            DateCreated.Size = new Size(97, 20);
            DateCreated.TabIndex = 1;
            DateCreated.Text = "Date Created";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(776, 266);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(772, 191);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(76, 20);
            lbFirstName.TabIndex = 3;
            lbFirstName.Text = "FirstName";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(1070, 187);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(72, 20);
            lbLastName.TabIndex = 4;
            lbLastName.Text = "Lastname";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(772, 115);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 5;
            lbPhone.Text = "Phone";
            // 
            // lbdateofbirth
            // 
            lbdateofbirth.AutoSize = true;
            lbdateofbirth.Location = new Point(1070, 115);
            lbdateofbirth.Name = "lbdateofbirth";
            lbdateofbirth.Size = new Size(96, 20);
            lbdateofbirth.TabIndex = 6;
            lbdateofbirth.Text = "Date Of Birth";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(444, 263);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(32, 20);
            lbSex.TabIndex = 7;
            lbSex.Text = "Sex";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(588, 109);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(153, 27);
            txtCustomerID.TabIndex = 8;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Location = new Point(588, 191);
            txtDateCreated.Margin = new Padding(3, 2, 3, 2);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.Size = new Size(153, 27);
            txtDateCreated.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(861, 252);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(861, 184);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(1193, 180);
            txtLastname.Margin = new Padding(3, 2, 3, 2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(332, 27);
            txtLastname.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(861, 112);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 27);
            txtPhone.TabIndex = 13;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(1193, 112);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(332, 27);
            txtDateOfBirth.TabIndex = 14;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(588, 263);
            txtSex.Margin = new Padding(3, 2, 3, 2);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(153, 27);
            txtSex.TabIndex = 15;
            txtSex.TextChanged += txtSex_TextChanged;
            // 
            // dgvlistview
            // 
            dgvlistview.CausesValidation = false;
            dgvlistview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistview.Location = new Point(444, 430);
            dgvlistview.Margin = new Padding(3, 2, 3, 2);
            dgvlistview.Name = "dgvlistview";
            dgvlistview.RowHeadersWidth = 51;
            dgvlistview.RowTemplate.Height = 29;
            dgvlistview.Size = new Size(1014, 219);
            dgvlistview.TabIndex = 16;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(514, 364);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 17;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(651, 361);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 27);
            txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1221, 359);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(504, 669);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(670, 669);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
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
            cbSearch.Location = new Point(1015, 361);
            cbSearch.Margin = new Padding(3, 2, 3, 2);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(73, 28);
            cbSearch.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1070, 255);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 25;
            label1.Text = "Address";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(1193, 249);
            txtAdress.Margin = new Padding(3, 2, 3, 2);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(332, 41);
            txtAdress.TabIndex = 26;
            txtAdress.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(793, 28);
            label2.Name = "label2";
            label2.Size = new Size(326, 38);
            label2.TabIndex = 27;
            label2.Text = "Customer Management";
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 961);
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