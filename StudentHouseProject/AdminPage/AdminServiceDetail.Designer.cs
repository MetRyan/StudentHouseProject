namespace StudentHouseProject.AdminAPage
{
    partial class AdminServiceDetail
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
            btnUpdateService = new Button();
            txtServicePrice = new TextBox();
            label5 = new Label();
            txtAmountOfTime = new TextBox();
            label3 = new Label();
            txtServiceName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbStatus = new ComboBox();
            label8 = new Label();
            txtServiceId = new TextBox();
            label9 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnUpdateService
            // 
            btnUpdateService.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateService.Location = new Point(420, 344);
            btnUpdateService.Margin = new Padding(3, 2, 3, 2);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(130, 32);
            btnUpdateService.TabIndex = 32;
            btnUpdateService.Text = "Update Service";
            btnUpdateService.UseVisualStyleBackColor = true;
            btnUpdateService.Click += btnSave_Click;
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(359, 232);
            txtServicePrice.Margin = new Padding(3, 2, 3, 2);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(245, 23);
            txtServicePrice.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(180, 235);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 28;
            label5.Text = "Price (VNĐ)";
            // 
            // txtAmountOfTime
            // 
            txtAmountOfTime.Location = new Point(359, 186);
            txtAmountOfTime.Margin = new Padding(3, 2, 3, 2);
            txtAmountOfTime.Name = "txtAmountOfTime";
            txtAmountOfTime.Size = new Size(245, 23);
            txtAmountOfTime.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(180, 189);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 24;
            label3.Text = "Time (minute)";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(359, 142);
            txtServiceName.Margin = new Padding(3, 2, 3, 2);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(245, 23);
            txtServiceName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(180, 145);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 22;
            label2.Text = "Service Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 38);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 21;
            label1.Text = "Update Service";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "True", "False" });
            cbStatus.Location = new Point(359, 280);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(245, 23);
            cbStatus.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(180, 283);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 45;
            label8.Text = "Status";
            // 
            // txtServiceId
            // 
            txtServiceId.Location = new Point(359, 97);
            txtServiceId.Margin = new Padding(3, 2, 3, 2);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new Size(245, 23);
            txtServiceId.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(180, 100);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 43;
            label9.Text = "Service Id";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(214, 344);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(130, 32);
            btnReturn.TabIndex = 30;
            btnReturn.Text = "Return to Home";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // AdminServiceDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 452);
            Controls.Add(cbStatus);
            Controls.Add(label8);
            Controls.Add(txtServiceId);
            Controls.Add(label9);
            Controls.Add(btnUpdateService);
            Controls.Add(btnReturn);
            Controls.Add(txtServicePrice);
            Controls.Add(label5);
            Controls.Add(txtAmountOfTime);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminServiceDetail";
            Text = "Update Service";
            Load += AdminServiceDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateService;
        private TextBox txtServicePrice;
        private Label label5;
        private TextBox txtAssignedStaff;
        private Label label4;
        private TextBox txtAmountOfTime;
        private Label label3;
        private TextBox txtServiceName;
        private Label label2;
        private Label label1;
        private ComboBox cbStatus;
        private Label label8;
        private TextBox txtServiceId;
        private Label label9;
        private Button btnReturn;
    }
}