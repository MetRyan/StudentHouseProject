namespace StudentHouseProject
{
    partial class UserHome
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
            dgvServices = new DataGridView();
            lbNotification = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(341, 30);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(35, 105);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(722, 293);
            dgvServices.TabIndex = 1;
            dgvServices.CellContentClick += dgvServices_CellContentClick;
            // 
            // lbNotification
            // 
            lbNotification.AutoSize = true;
            lbNotification.Location = new Point(276, 72);
            lbNotification.Name = "lbNotification";
            lbNotification.Size = new Size(240, 20);
            lbNotification.TabIndex = 2;
            lbNotification.Text = "Choose the service you want to use";
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNotification);
            Controls.Add(dgvServices);
            Controls.Add(label1);
            Name = "UserHome";
            Text = "UserHome";
            Load += UserHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvServices;
        private Label lbNotification;
    }
}