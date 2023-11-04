namespace StudentHouseProject.StaffPage
{
    partial class StaffViewServiceDetails
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
            dgvProductDetails = new DataGridView();
            txtPhone = new TextBox();
            cbPending = new ComboBox();
            txtAddress = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            button2 = new Button();
            txtName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            cbStatusWork = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvProductDetails
            // 
            dgvProductDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductDetails.Location = new Point(143, 287);
            dgvProductDetails.Margin = new Padding(3, 2, 3, 2);
            dgvProductDetails.Name = "dgvProductDetails";
            dgvProductDetails.RowHeadersWidth = 51;
            dgvProductDetails.RowTemplate.Height = 29;
            dgvProductDetails.Size = new Size(733, 190);
            dgvProductDetails.TabIndex = 49;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(699, 129);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(165, 23);
            txtPhone.TabIndex = 48;
            // 
            // cbPending
            // 
            cbPending.FormattingEnabled = true;
            cbPending.Items.AddRange(new object[] { "True", "False" });
            cbPending.Location = new Point(699, 69);
            cbPending.Margin = new Padding(3, 2, 3, 2);
            cbPending.Name = "cbPending";
            cbPending.Size = new Size(165, 23);
            cbPending.TabIndex = 47;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(270, 129);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(245, 23);
            txtAddress.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(601, 129);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 45;
            label5.Text = "phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(601, 75);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 44;
            label4.Text = "Pending";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(143, 129);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 43;
            label6.Text = "Address";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(659, 177);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(130, 32);
            button2.TabIndex = 42;
            button2.Text = "Return to Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(270, 75);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 23);
            txtName.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(143, 75);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 38;
            label8.Text = "Service Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(329, 20);
            label9.Name = "label9";
            label9.Size = new Size(138, 25);
            label9.TabIndex = 37;
            label9.Text = "Service Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 234);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 50;
            label1.Text = "Update Status Work";
            // 
            // cbStatusWork
            // 
            cbStatusWork.FormattingEnabled = true;
            cbStatusWork.Items.AddRange(new object[] { "True", "False" });
            cbStatusWork.Location = new Point(270, 231);
            cbStatusWork.Name = "cbStatusWork";
            cbStatusWork.Size = new Size(160, 23);
            cbStatusWork.TabIndex = 51;
            cbStatusWork.SelectedIndexChanged += cbPending_SelectedIndexChanged;
            // 
            // StaffViewServiceDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 518);
            Controls.Add(cbStatusWork);
            Controls.Add(label1);
            Controls.Add(dgvProductDetails);
            Controls.Add(txtPhone);
            Controls.Add(cbPending);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label9);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffViewServiceDetails";
            Text = "Service Details";
            FormClosed += StaffViewServiceDetails_FormClosed;
            Load += StaffViewServiceDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductDetails;
        private TextBox txtPhone;
        private ComboBox cbPending;
        private TextBox txtAddress;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button button2;
        private TextBox txtName;
        private Label label8;
        private Label label9;
        private Label label1;
        private ComboBox cbStatusWork;
    }
}