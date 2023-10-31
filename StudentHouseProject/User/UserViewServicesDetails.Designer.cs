namespace StudentHouseProject.User
{
    partial class UserViewServicesDetails
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
            txtServiceName = new TextBox();
            label3 = new Label();
            txtAmountOfTime = new TextBox();
            label4 = new Label();
            txtAssignedStaff = new TextBox();
            label5 = new Label();
            txtServicePrice = new TextBox();
            btnBook = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 36);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 0;
            label1.Text = "Service Details";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(137, 114);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Service Name";
            label2.Click += label2_Click;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(451, 114);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(279, 27);
            txtServiceName.TabIndex = 2;
            txtServiceName.TextChanged += txtServiceName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(137, 184);
            label3.Name = "label3";
            label3.Size = new Size(308, 20);
            label3.TabIndex = 3;
            label3.Text = "Time length to complete the service (Hours)";
            label3.Click += label3_Click;
            // 
            // txtAmountOfTime
            // 
            txtAmountOfTime.Location = new Point(451, 181);
            txtAmountOfTime.Name = "txtAmountOfTime";
            txtAmountOfTime.Size = new Size(279, 27);
            txtAmountOfTime.TabIndex = 4;
            txtAmountOfTime.TextChanged += txtAmountOfTime_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(137, 252);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 5;
            label4.Text = "Staff";
            label4.Click += label4_Click;
            // 
            // txtAssignedStaff
            // 
            txtAssignedStaff.Location = new Point(451, 249);
            txtAssignedStaff.Name = "txtAssignedStaff";
            txtAssignedStaff.Size = new Size(279, 27);
            txtAssignedStaff.TabIndex = 6;
            txtAssignedStaff.TextChanged += txtAssignedStaff_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(137, 317);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 7;
            label5.Text = "Price (VNĐ)";
            label5.Click += label5_Click;
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(451, 314);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(279, 27);
            txtServicePrice.TabIndex = 8;
            txtServicePrice.TextChanged += txtServicePrice_TextChanged;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.Location = new Point(425, 403);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(137, 42);
            btnBook.TabIndex = 9;
            btnBook.Text = "Book Service";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(582, 403);
            button1.Name = "button1";
            button1.Size = new Size(148, 42);
            button1.TabIndex = 10;
            button1.Text = "Return to Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserViewServicesDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 483);
            Controls.Add(button1);
            Controls.Add(btnBook);
            Controls.Add(txtServicePrice);
            Controls.Add(label5);
            Controls.Add(txtAssignedStaff);
            Controls.Add(label4);
            Controls.Add(txtAmountOfTime);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserViewServicesDetails";
            Text = "Service Details";
            Load += UserViewServicesDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtServiceName;
        private Label label3;
        private TextBox txtAmountOfTime;
        private Label label4;
        private TextBox txtAssignedStaff;
        private Label label5;
        private TextBox txtServicePrice;
        private Button btnBook;
        private Button button1;
    }
}