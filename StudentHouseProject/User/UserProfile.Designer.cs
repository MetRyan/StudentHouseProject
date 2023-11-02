namespace StudentHouseProject.User
{
    partial class UserProfile
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbFirstName = new Label();
            txtFirstName = new TextBox();
            lbLastName = new Label();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            lbEmail = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            lbDoB = new Label();
            txtDoB = new MaskedTextBox();
            lbAddress = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnReturn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 43);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 0;
            label1.Text = "User Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0232544F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.9767456F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableLayoutPanel1.Controls.Add(txtAddress, 3, 2);
            tableLayoutPanel1.Controls.Add(txtPhone, 3, 1);
            tableLayoutPanel1.Controls.Add(lbFirstName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(lbLastName, 2, 0);
            tableLayoutPanel1.Controls.Add(txtLastName, 3, 0);
            tableLayoutPanel1.Controls.Add(lbEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(lbDoB, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDoB, 1, 2);
            tableLayoutPanel1.Controls.Add(lbAddress, 2, 2);
            tableLayoutPanel1.Location = new Point(122, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(442, 129);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(3, 0);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(64, 15);
            lbFirstName.TabIndex = 4;
            lbFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(74, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(138, 23);
            txtFirstName.TabIndex = 5;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(218, 0);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(63, 15);
            lbLastName.TabIndex = 6;
            lbLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(292, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(147, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 46);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(138, 23);
            txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(3, 43);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 43);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(292, 46);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(147, 23);
            txtPhone.TabIndex = 9;
            // 
            // lbDoB
            // 
            lbDoB.AutoSize = true;
            lbDoB.Location = new Point(3, 86);
            lbDoB.Name = "lbDoB";
            lbDoB.Size = new Size(48, 30);
            lbDoB.TabIndex = 10;
            lbDoB.Text = "Date of Birth";
            // 
            // txtDoB
            // 
            txtDoB.Location = new Point(74, 89);
            txtDoB.Mask = "00/00/0000";
            txtDoB.Name = "txtDoB";
            txtDoB.Size = new Size(138, 23);
            txtDoB.TabIndex = 11;
            txtDoB.ValidatingType = typeof(DateTime);
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(218, 86);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(49, 15);
            lbAddress.TabIndex = 12;
            lbAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(292, 89);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(147, 23);
            txtAddress.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(259, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.UseWaitCursor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(355, 262);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 365);
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbFirstName;
        private TextBox txtFirstName;
        private Label lbLastName;
        private TextBox txtLastName;
        private Label lbEmail;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label3;
        private Label lbDoB;
        private MaskedTextBox txtDoB;
        private TextBox txtAddress;
        private Label lbAddress;
        private Button btnSave;
        private Button btnReturn;
    }
}