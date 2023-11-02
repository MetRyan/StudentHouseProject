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
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnRegister);
            panelMenu.Controls.Add(btnLogin);
            panelMenu.Controls.Add(btnCart);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Controls.Add(btnHomepage);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 857);
            panelMenu.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 662);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(250, 115);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Top;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(0, 547);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 115);
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
            btnLogin.Location = new Point(0, 432);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 115);
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
            btnCart.Location = new Point(0, 317);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(250, 115);
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
            btnProfile.Location = new Point(0, 202);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(250, 115);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = SystemColors.ActiveCaption;
            btnHomepage.Dock = DockStyle.Top;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomepage.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomepage.Location = new Point(0, 71);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(250, 131);
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
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 71);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.ControlDark;
            panelTitleBar.Controls.Add(lbTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(829, 71);
            panelTitleBar.TabIndex = 2;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(366, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(87, 35);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 71);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(829, 786);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 857);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainMenu";
            Text = "MainMenu";
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
    }
}