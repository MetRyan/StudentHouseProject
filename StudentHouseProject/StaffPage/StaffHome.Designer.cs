namespace StudentHouseProject.StaffPage
{
    partial class StaffHome
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
            dgvStaff = new DataGridView();
            btnViewDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(394, 33);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 1;
            label1.Text = "Welcome back Staff!";
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(42, 118);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 29;
            dgvStaff.Size = new Size(983, 365);
            dgvStaff.TabIndex = 2;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewDetails.Location = new Point(42, 74);
            btnViewDetails.Margin = new Padding(3, 2, 3, 2);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(108, 27);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // StaffHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 509);
            Controls.Add(btnViewDetails);
            Controls.Add(dgvStaff);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffHome";
            Text = "Home (Staff)";
            FormClosed += StaffHome_FormClosed;
            Load += StaffHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvStaff;
        private Button btnViewDetails;
    }
}