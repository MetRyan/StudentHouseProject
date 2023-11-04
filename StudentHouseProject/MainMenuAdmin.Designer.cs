namespace UI
{
    partial class MainMenuAdmin
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
            panelLogo = new Panel();
            panelDesktop = new Panel();
            panelTitleBar = new Panel();
            lbTitle = new Label();
            panelMenu = new Panel();
            button1 = new Button();
            button2 = new Button();
            btnCustomerManagent = new Button();
            btnStaff = new Button();
            btnAdminViewServiceDetails = new Button();
            btnAssignServicetoStaff = new Button();
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.AppWorkspace;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 71);
            panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 71);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1062, 708);
            panelDesktop.TabIndex = 6;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.ControlDark;
            panelTitleBar.Controls.Add(lbTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1062, 71);
            panelTitleBar.TabIndex = 5;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(505, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(87, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnCustomerManagent);
            panelMenu.Controls.Add(btnStaff);
            panelMenu.Controls.Add(btnAdminViewServiceDetails);
            panelMenu.Controls.Add(btnAssignServicetoStaff);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 779);
            panelMenu.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 609);
            button1.Name = "button1";
            button1.Size = new Size(250, 93);
            button1.TabIndex = 5;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLogOut_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 509);
            button2.Name = "button2";
            button2.Size = new Size(250, 100);
            button2.TabIndex = 6;
            button2.Text = "Check Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCustomerManagent
            // 
            btnCustomerManagent.Dock = DockStyle.Top;
            btnCustomerManagent.FlatStyle = FlatStyle.Flat;
            btnCustomerManagent.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerManagent.Location = new Point(0, 402);
            btnCustomerManagent.Name = "btnCustomerManagent";
            btnCustomerManagent.Size = new Size(250, 107);
            btnCustomerManagent.TabIndex = 4;
            btnCustomerManagent.Text = "Customer Managment";
            btnCustomerManagent.UseVisualStyleBackColor = true;
            btnCustomerManagent.Click += btnCustomerManagent_Click;
            // 
            // btnStaff
            // 
            btnStaff.Dock = DockStyle.Top;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(0, 307);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(250, 95);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff Management";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnAdminViewServiceDetails
            // 
            btnAdminViewServiceDetails.Dock = DockStyle.Top;
            btnAdminViewServiceDetails.FlatStyle = FlatStyle.Flat;
            btnAdminViewServiceDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminViewServiceDetails.Location = new Point(0, 202);
            btnAdminViewServiceDetails.Name = "btnAdminViewServiceDetails";
            btnAdminViewServiceDetails.Size = new Size(250, 105);
            btnAdminViewServiceDetails.TabIndex = 2;
            btnAdminViewServiceDetails.Text = "ServiceDetails";
            btnAdminViewServiceDetails.UseVisualStyleBackColor = true;
            btnAdminViewServiceDetails.Click += btnAdminViewServiceDetails_Click;
            // 
            // btnAssignServicetoStaff
            // 
            btnAssignServicetoStaff.BackColor = SystemColors.ActiveCaption;
            btnAssignServicetoStaff.Dock = DockStyle.Top;
            btnAssignServicetoStaff.FlatStyle = FlatStyle.Flat;
            btnAssignServicetoStaff.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssignServicetoStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnAssignServicetoStaff.Location = new Point(0, 71);
            btnAssignServicetoStaff.Name = "btnAssignServicetoStaff";
            btnAssignServicetoStaff.Size = new Size(250, 131);
            btnAssignServicetoStaff.TabIndex = 1;
            btnAssignServicetoStaff.Text = "AssignServicetoStaff";
            btnAssignServicetoStaff.UseVisualStyleBackColor = false;
            btnAssignServicetoStaff.Click += btnAssignServicetoStaff_Click;
            // 
            // MainMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 779);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainMenuAdmin";
            Text = "MainMenuAdmincs";
            FormClosed += MainMenu_FormClosed;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel panelDesktop;
        private Panel panelTitleBar;
        private Label lbTitle;
        private Panel panelMenu;
        private Button btnLogin;
        private Button btnResgiter;
        private Button btnAboutus;
        private Button btnStaff;
        private Button btnAdminViewServiceDetails;
        private Button btnAssignServicetoStaff;
        private Button btnCustomerManagent;
        private Button button1;
        private Button button2;
    }
}