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
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 53);
            panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(219, 53);
            panelDesktop.Margin = new Padding(3, 2, 3, 2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1000, 476);
            panelDesktop.TabIndex = 6;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.ControlDark;
            panelTitleBar.Controls.Add(lbTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(219, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1000, 53);
            panelTitleBar.TabIndex = 5;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(477, 7);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(69, 28);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnCustomerManagent);
            panelMenu.Controls.Add(btnStaff);
            panelMenu.Controls.Add(btnAdminViewServiceDetails);
            panelMenu.Controls.Add(btnAssignServicetoStaff);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 529);
            panelMenu.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 409);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(219, 86);
            button1.TabIndex = 5;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLogOut_Click;
            // 
            // btnCustomerManagent
            // 
            btnCustomerManagent.Dock = DockStyle.Top;
            btnCustomerManagent.FlatStyle = FlatStyle.Flat;
            btnCustomerManagent.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerManagent.Location = new Point(0, 323);
            btnCustomerManagent.Margin = new Padding(3, 2, 3, 2);
            btnCustomerManagent.Name = "btnCustomerManagent";
            btnCustomerManagent.Size = new Size(219, 86);
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
            btnStaff.Location = new Point(0, 237);
            btnStaff.Margin = new Padding(3, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(219, 86);
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
            btnAdminViewServiceDetails.Location = new Point(0, 151);
            btnAdminViewServiceDetails.Margin = new Padding(3, 2, 3, 2);
            btnAdminViewServiceDetails.Name = "btnAdminViewServiceDetails";
            btnAdminViewServiceDetails.Size = new Size(219, 86);
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
            btnAssignServicetoStaff.Location = new Point(0, 53);
            btnAssignServicetoStaff.Margin = new Padding(3, 2, 3, 2);
            btnAssignServicetoStaff.Name = "btnAssignServicetoStaff";
            btnAssignServicetoStaff.Size = new Size(219, 98);
            btnAssignServicetoStaff.TabIndex = 1;
            btnAssignServicetoStaff.Text = "AssignServicetoStaff";
            btnAssignServicetoStaff.UseVisualStyleBackColor = false;
            btnAssignServicetoStaff.Click += btnAssignServicetoStaff_Click;
            // 
            // MainMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 529);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}