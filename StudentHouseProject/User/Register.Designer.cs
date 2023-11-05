namespace StudentHouseProject.User
{
    partial class Register
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            label7 = new Label();
            cbGender = new ComboBox();
            label2 = new Label();
            btnReset = new Button();
            dtpDob = new DateTimePicker();
            txtAddress = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(261, 421);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(116, 32);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(149, 187);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your Password";
            txtPassword.Size = new Size(263, 23);
            txtPassword.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(149, 170);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 258);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your Email";
            txtEmail.Size = new Size(263, 23);
            txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 241);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 35);
            label1.Name = "label1";
            label1.Size = new Size(287, 21);
            label1.TabIndex = 7;
            label1.Text = "Welcome to Student House Service! ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(468, 118);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Enter your Last name";
            txtLastName.Size = new Size(265, 23);
            txtLastName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(468, 101);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 16;
            label5.Text = "LastName";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(149, 118);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Enter your First name";
            txtFirstName.Size = new Size(263, 23);
            txtFirstName.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(149, 101);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 14;
            label6.Text = "FirstName";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(468, 187);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Enter your Phone number";
            txtPhone.Size = new Size(265, 23);
            txtPhone.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(468, 170);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 18;
            label8.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(468, 240);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 23;
            label7.Text = "Date Of Birth";
            // 
            // cbGender
            // 
            cbGender.BackColor = SystemColors.Window;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(468, 322);
            cbGender.Margin = new Padding(3, 2, 3, 2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(71, 23);
            cbGender.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(468, 305);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 25;
            label2.Text = "Gender";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(468, 421);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(116, 32);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(468, 258);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(265, 23);
            dtpDob.TabIndex = 27;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(149, 322);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(263, 23);
            txtAddress.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(149, 305);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 30;
            label10.Text = "Address";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 556);
            Controls.Add(label10);
            Controls.Add(txtAddress);
            Controls.Add(dtpDob);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(cbGender);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label8);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private Label label1;
        private TextBox txtLastName;
        private Label label5;
        private TextBox txtFirstName;
        private Label label6;
        private TextBox txtPhone;
        private Label label8;
        private Label label7;
        private ComboBox cbGender;
        private Label label2;
        private Button btnReset;
        private DateTimePicker dtpDob;
        private TextBox txtAddress;
        private Label label10;
    }
}