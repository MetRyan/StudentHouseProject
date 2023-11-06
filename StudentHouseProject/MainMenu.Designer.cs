namespace UI
{
    partial class MainMenu
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
            panelMenu = new Panel();
            btnOrderHis = new Button();
            btnLogOut = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            btnCart = new Button();
            btnProfile = new Button();
            btnHomepage = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lbTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(btnOrderHis);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnRegister);
            panelMenu.Controls.Add(btnLogin);
            panelMenu.Controls.Add(btnCart);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Controls.Add(btnHomepage);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 789);
            panelMenu.TabIndex = 1;
            // 
            // btnOrderHis
            // 
            btnOrderHis.Dock = DockStyle.Top;
            btnOrderHis.FlatStyle = FlatStyle.Flat;
            btnOrderHis.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrderHis.Location = new Point(0, 581);
            btnOrderHis.Margin = new Padding(3, 2, 3, 2);
            btnOrderHis.Name = "btnOrderHis";
            btnOrderHis.Size = new Size(219, 86);
            btnOrderHis.TabIndex = 7;
            btnOrderHis.Text = "Order History";
            btnOrderHis.UseVisualStyleBackColor = true;
            btnOrderHis.Click += btnHistoryOrder;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 495);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(219, 86);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Top;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(0, 409);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(219, 86);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(0, 323);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 86);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCart
            // 
            btnCart.Dock = DockStyle.Top;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(0, 237);
            btnCart.Margin = new Padding(3, 2, 3, 2);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(219, 86);
            btnCart.TabIndex = 3;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += button1_Click;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 151);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(219, 86);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = SystemColors.ActiveCaption;
            btnHomepage.Dock = DockStyle.Top;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomepage.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomepage.Location = new Point(0, 53);
            btnHomepage.Margin = new Padding(3, 2, 3, 2);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(219, 98);
            btnHomepage.TabIndex = 1;
            btnHomepage.Text = "Homepage";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += btnHomepage_Click;
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
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.ControlDark;
            panelTitleBar.Controls.Add(lbTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(219, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1057, 53);
            panelTitleBar.TabIndex = 2;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(404, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(258, 28);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "STUDENT HOUSE SERVICE";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(219, 53);
            panelDesktop.Margin = new Padding(3, 2, 3, 2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1057, 736);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 789);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenu";
            Text = "Main Menu";
            FormClosed += MainMenu_FormClosed;
            Load += MainMenu_Load;
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private Panel panelMenu;
        private Button btnProfile;
        private Button btnHomepage;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lbTitle;
        private Panel panelDesktop;
        private Button btnCart;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnLogOut;
        private Button btnOrderHis;
    }
}