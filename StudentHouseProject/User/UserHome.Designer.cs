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
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(710, 7);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // lbNotification
            // 
            lbNotification.AutoSize = true;
            lbNotification.Location = new Point(665, 38);
            lbNotification.Name = "lbNotification";
            lbNotification.Size = new Size(193, 15);
            lbNotification.TabIndex = 2;
            lbNotification.Text = "Choose the service you want to use";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(179, 115);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1181, 490);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 71);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 6;
            label2.Text = "Scroll to see all Service";
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1348, 706);
            Controls.Add(label2);
            Controls.Add(lbNotification);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label2;
    }
}