namespace StudentHouseProject.AdminAPage
{
    partial class AdminViewServiceDetails
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
            txtServicePrice = new TextBox();
            label5 = new Label();
            txtAssignedStaff = new TextBox();
            label4 = new Label();
            txtAmountOfTime = new TextBox();
            label3 = new Label();
            txtServiceName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnReturn = new Button();
            btnDeleteService = new Button();
            btnUpdateService = new Button();
            label6 = new Label();
            txtStartedDate = new TextBox();
            label7 = new Label();
            txtEndedDate = new TextBox();
            SuspendLayout();
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(447, 300);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(279, 27);
            txtServicePrice.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(133, 303);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 16;
            label5.Text = "Price (VNĐ)";
            // 
            // txtAssignedStaff
            // 
            txtAssignedStaff.Location = new Point(447, 235);
            txtAssignedStaff.Name = "txtAssignedStaff";
            txtAssignedStaff.Size = new Size(279, 27);
            txtAssignedStaff.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(133, 238);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 14;
            label4.Text = "Staff";
            // 
            // txtAmountOfTime
            // 
            txtAmountOfTime.Location = new Point(447, 167);
            txtAmountOfTime.Name = "txtAmountOfTime";
            txtAmountOfTime.Size = new Size(279, 27);
            txtAmountOfTime.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(133, 170);
            label3.Name = "label3";
            label3.Size = new Size(308, 20);
            label3.TabIndex = 12;
            label3.Text = "Time length to complete the service (Hours)";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(447, 100);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(279, 27);
            txtServiceName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(133, 100);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.Text = "Service Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 23);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 9;
            label1.Text = "Service Details";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(667, 520);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(148, 42);
            btnReturn.TabIndex = 18;
            btnReturn.Text = "Return to Home";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteService.Location = new Point(513, 520);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(148, 42);
            btnDeleteService.TabIndex = 19;
            btnDeleteService.Text = "Remove Service";
            btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            btnUpdateService.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateService.Location = new Point(359, 520);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(148, 42);
            btnUpdateService.TabIndex = 20;
            btnUpdateService.Text = "Update Service";
            btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(133, 372);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 21;
            label6.Text = "Started Date";
            // 
            // txtStartedDate
            // 
            txtStartedDate.Location = new Point(447, 365);
            txtStartedDate.Name = "txtStartedDate";
            txtStartedDate.Size = new Size(279, 27);
            txtStartedDate.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(133, 441);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 23;
            label7.Text = "Ended Date";
            // 
            // txtEndedDate
            // 
            txtEndedDate.Location = new Point(447, 434);
            txtEndedDate.Name = "txtEndedDate";
            txtEndedDate.Size = new Size(279, 27);
            txtEndedDate.TabIndex = 24;
            // 
            // AdminViewServiceDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 586);
            Controls.Add(txtEndedDate);
            Controls.Add(label7);
            Controls.Add(txtStartedDate);
            Controls.Add(label6);
            Controls.Add(btnUpdateService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnReturn);
            Controls.Add(txtServicePrice);
            Controls.Add(label5);
            Controls.Add(txtAssignedStaff);
            Controls.Add(label4);
            Controls.Add(txtAmountOfTime);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminViewServiceDetails";
            Text = "Service Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServicePrice;
        private Label label5;
        private TextBox txtAssignedStaff;
        private Label label4;
        private TextBox txtAmountOfTime;
        private Label label3;
        private TextBox txtServiceName;
        private Label label2;
        private Label label1;
        private Button btnReturn;
        private Button btnDeleteService;
        private Button btnUpdateService;
        private Label label6;
        private TextBox txtStartedDate;
        private Label label7;
        private TextBox txtEndedDate;
    }
}