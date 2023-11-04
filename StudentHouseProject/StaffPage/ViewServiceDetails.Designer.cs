namespace StudentHouseProject.StaffPage
{
    partial class ViewServiceDetails
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
            button1 = new Button();
            txtServicePrice = new TextBox();
            txtStartedDate = new Label();
            txtServiceName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            comboBox1 = new ComboBox();
            txtPhone = new TextBox();
            dgvProductDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(669, 277);
            button1.Name = "button1";
            button1.Size = new Size(149, 43);
            button1.TabIndex = 28;
            button1.Text = "Return to Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(275, 213);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(279, 27);
            txtServicePrice.TabIndex = 27;
            // 
            // txtStartedDate
            // 
            txtStartedDate.AutoSize = true;
            txtStartedDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtStartedDate.Location = new Point(129, 217);
            txtStartedDate.Name = "txtStartedDate";
            txtStartedDate.Size = new Size(95, 20);
            txtStartedDate.TabIndex = 26;
            txtStartedDate.Text = "Started Time";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(275, 148);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(279, 27);
            txtServiceName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(129, 148);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 22;
            label2.Text = "Service Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 75);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 21;
            label1.Text = "Service Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(129, 293);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 29;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(653, 148);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 30;
            label4.Text = "Pending";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(653, 220);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 31;
            label5.Text = "phone";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(275, 293);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(279, 27);
            txtAddress.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "true", "false" });
            comboBox1.Location = new Point(765, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 28);
            comboBox1.TabIndex = 34;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(765, 220);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(188, 27);
            txtPhone.TabIndex = 35;
            // 
            // dgvProductDetails
            // 
            dgvProductDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductDetails.Location = new Point(129, 413);
            dgvProductDetails.Name = "dgvProductDetails";
            dgvProductDetails.RowHeadersWidth = 51;
            dgvProductDetails.RowTemplate.Height = 29;
            dgvProductDetails.Size = new Size(838, 253);
            dgvProductDetails.TabIndex = 36;
            // 
            // ViewServiceDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 801);
            Controls.Add(dgvProductDetails);
            Controls.Add(txtPhone);
            Controls.Add(comboBox1);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtServicePrice);
            Controls.Add(txtStartedDate);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewServiceDetails";
            Text = "ViewServiceDetails";
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtServicePrice;
        private Label txtStartedDate;
        private TextBox txtServiceName;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAddress;
        private ComboBox comboBox1;
        private TextBox txtPhone;
        private DataGridView dgvProductDetails;
    }
}