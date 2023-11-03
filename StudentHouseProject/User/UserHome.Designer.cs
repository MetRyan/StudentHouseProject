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
            lbNotification = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(335, 12);
            label1.Name = "label1";
            label1.Size = new Size(147, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // lbNotification
            // 
            lbNotification.AutoSize = true;
            lbNotification.Location = new Point(298, 55);
            lbNotification.Name = "lbNotification";
            lbNotification.Size = new Size(240, 20);
            lbNotification.TabIndex = 2;
            lbNotification.Text = "Choose the service you want to use";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(38, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(816, 506);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 1013);
            Controls.Add(lbNotification);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "UserHome";
            Text = "UserHome";
            Load += UserHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbNotification;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}