namespace StudentHouseProject.Staff
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
            button1 = new Button();
            txtServicePrice = new TextBox();
            txtStartedDate = new Label();
            txtAmountOfTime = new TextBox();
            label3 = new Label();
            txtServiceName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(627, 311);
            button1.Name = "button1";
            button1.Size = new Size(148, 42);
            button1.TabIndex = 20;
            button1.Text = "Return to Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(418, 238);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(279, 27);
            txtServicePrice.TabIndex = 19;
            // 
            // txtStartedDate
            // 
            txtStartedDate.AutoSize = true;
            txtStartedDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtStartedDate.Location = new Point(104, 238);
            txtStartedDate.Name = "txtStartedDate";
            txtStartedDate.Size = new Size(95, 20);
            txtStartedDate.TabIndex = 18;
            txtStartedDate.Text = "Started Time";
            // 
            // txtAmountOfTime
            // 
            txtAmountOfTime.Location = new Point(418, 165);
            txtAmountOfTime.Name = "txtAmountOfTime";
            txtAmountOfTime.Size = new Size(279, 27);
            txtAmountOfTime.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(104, 168);
            label3.Name = "label3";
            label3.Size = new Size(308, 20);
            label3.TabIndex = 14;
            label3.Text = "Time length to complete the service (Hours)";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(418, 98);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(279, 27);
            txtServiceName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 98);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 12;
            label2.Text = "Service Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 25);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 11;
            label1.Text = "Service Details";
            // 
            // StaffViewServiceDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 408);
            Controls.Add(button1);
            Controls.Add(txtServicePrice);
            Controls.Add(txtStartedDate);
            Controls.Add(txtAmountOfTime);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffViewServiceDetails";
            Text = "Service Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtServicePrice;
        private Label txtStartedDate;
        private TextBox txtAmountOfTime;
        private Label label3;
        private TextBox txtServiceName;
        private Label label2;
        private Label label1;
    }
}