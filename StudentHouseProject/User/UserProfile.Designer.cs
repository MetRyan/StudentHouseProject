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
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            lbFirstName = new Label();
            txtFirstName = new TextBox();
            lbLastName = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            lbDoB = new Label();
            lbAddress = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            cbSex = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            cbxShowPassword = new CheckBox();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(471, 27);
            label1.Name = "label1";
            label1.Size = new Size(170, 38);
            label1.TabIndex = 0;
            label1.Text = "User Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 131);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6574059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3425941F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
            tableLayoutPanel1.Controls.Add(txtAddress, 3, 2);
            tableLayoutPanel1.Controls.Add(txtPhone, 3, 1);
            tableLayoutPanel1.Controls.Add(lbFirstName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(lbLastName, 2, 0);
            tableLayoutPanel1.Controls.Add(txtLastName, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(lbDoB, 0, 2);
            tableLayoutPanel1.Controls.Add(lbAddress, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(cbSex, 1, 1);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel1.Controls.Add(cbxShowPassword, 1, 4);
            tableLayoutPanel1.Location = new Point(139, 71);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            tableLayoutPanel1.Size = new Size(866, 413);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(691, 132);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(167, 27);
            txtAddress.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(691, 68);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(167, 27);
            txtPhone.TabIndex = 9;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(3, 0);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(80, 20);
            lbFirstName.TabIndex = 4;
            lbFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(176, 4);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(243, 27);
            txtFirstName.TabIndex = 5;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(451, 0);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(79, 20);
            lbLastName.TabIndex = 6;
            lbLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(691, 4);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 27);
            txtLastName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 64);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // lbDoB
            // 
            lbDoB.AutoSize = true;
            lbDoB.Location = new Point(3, 128);
            lbDoB.Name = "lbDoB";
            lbDoB.Size = new Size(94, 20);
            lbDoB.TabIndex = 10;
            lbDoB.Text = "Date of Birth";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(451, 128);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 12;
            lbAddress.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 184);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 188);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 27);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 64);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 16;
            label5.Text = "Sex";
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "FeMale" });
            cbSex.Location = new Point(176, 68);
            cbSex.Margin = new Padding(3, 4, 3, 4);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(243, 28);
            cbSex.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.Location = new Point(176, 229);
            cbxShowPassword.Margin = new Padding(3, 4, 3, 4);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(128, 24);
            cbxShowPassword.TabIndex = 19;
            cbxShowPassword.Text = "ShowPassword";
            cbxShowPassword.UseVisualStyleBackColor = true;
            cbxShowPassword.CheckedChanged += cbxShowPassword_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(518, 507);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 39);
            btnSave.TabIndex = 5;
            btnSave.Text = "Edit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.UseWaitCursor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 631);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
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
        private TextBox txtPhone;
        private Label label3;
        private Label lbDoB;
        private TextBox txtAddress;
        private Label lbAddress;
        private Button btnSave;
        private Label label5;
        private Label label4;
        private TextBox txtPassword;
        private ComboBox cbSex;
        private DateTimePicker dateTimePicker1;
        private CheckBox cbxShowPassword;
    }
}