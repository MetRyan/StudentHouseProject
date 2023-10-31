namespace StudentHouseProject.Admin
{
    partial class AdminAssignServiceToStaffs
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
            comboBox1 = new ComboBox();
            btnAssign = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 25);
            label1.Name = "label1";
            label1.Size = new Size(349, 38);
            label1.TabIndex = 1;
            label1.Text = "Assign Staff to the Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 108);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Service Name";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(304, 105);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(299, 27);
            txtServiceName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(169, 176);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Staff";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(304, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 28);
            comboBox1.TabIndex = 5;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssign.Location = new Point(484, 282);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(143, 47);
            btnAssign.TabIndex = 6;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(645, 282);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(143, 47);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // AdminAssignServiceToStaffs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(btnReturn);
            Controls.Add(btnAssign);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminAssignServiceToStaffs";
            Text = "Assign Staff to the Service";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtServiceName;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnAssign;
        private Button btnReturn;
    }
}