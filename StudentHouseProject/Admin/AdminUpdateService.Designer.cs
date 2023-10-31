namespace StudentHouseProject.Admin
{
    partial class AdminUpdateService
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
            btnReturn = new Button();
            txtServicePrice = new TextBox();
            label5 = new Label();
            txtAssignedStaff = new TextBox();
            label4 = new Label();
            txtAmountOfTime = new TextBox();
            label3 = new Label();
            txtServiceName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtStartedDate = new DateTimePicker();
            txtEndedDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnUpdateService
            // 
            btnUpdateService.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateService.Location = new Point(479, 523);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(148, 42);
            btnUpdateService.TabIndex = 32;
            btnUpdateService.Text = "Update Service";
            btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(633, 523);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(148, 42);
            btnReturn.TabIndex = 30;
            btnReturn.Text = "Return to Home";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(409, 296);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(279, 27);
            txtServicePrice.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(95, 299);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 28;
            label5.Text = "Price (VNĐ)";
            // 
            // txtAssignedStaff
            // 
            txtAssignedStaff.Location = new Point(409, 231);
            txtAssignedStaff.Name = "txtAssignedStaff";
            txtAssignedStaff.Size = new Size(279, 27);
            txtAssignedStaff.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(95, 234);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 26;
            label4.Text = "Staff";
            // 
            // txtAmountOfTime
            // 
            txtAmountOfTime.Location = new Point(409, 163);
            txtAmountOfTime.Name = "txtAmountOfTime";
            txtAmountOfTime.Size = new Size(279, 27);
            txtAmountOfTime.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(95, 166);
            label3.Name = "label3";
            label3.Size = new Size(308, 20);
            label3.TabIndex = 24;
            label3.Text = "Time length to complete the service (Hours)";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(409, 96);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(279, 27);
            txtServiceName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 96);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 22;
            label2.Text = "Service Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 22);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 21;
            label1.Text = "Update Service";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(95, 438);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 34;
            label7.Text = "Ended Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(95, 369);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 33;
            label6.Text = "Started Date";
            // 
            // txtStartedDate
            // 
            txtStartedDate.Location = new Point(409, 369);
            txtStartedDate.Name = "txtStartedDate";
            txtStartedDate.Size = new Size(279, 27);
            txtStartedDate.TabIndex = 35;
            // 
            // txtEndedDate
            // 
            txtEndedDate.Location = new Point(409, 438);
            txtEndedDate.Name = "txtEndedDate";
            txtEndedDate.Size = new Size(279, 27);
            txtEndedDate.TabIndex = 36;
            // 
            // AdminUpdateService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(txtEndedDate);
            Controls.Add(txtStartedDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnUpdateService);
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
            Name = "AdminUpdateService";
            Text = "Update Service";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateService;
        private Button btnReturn;
        private TextBox txtServicePrice;
        private Label label5;
        private TextBox txtAssignedStaff;
        private Label label4;
        private TextBox txtAmountOfTime;
        private Label label3;
        private TextBox txtServiceName;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private DateTimePicker txtStartedDate;
        private DateTimePicker txtEndedDate;
    }
}