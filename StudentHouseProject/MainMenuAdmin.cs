﻿using BusinessObjects;
using StudentHouseProject;
using StudentHouseProject.AdminAPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.AdminPage;

namespace UI
{
    public partial class MainMenuAdmin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Admin getAdmin { get; set; }
        public MainMenuAdmin()
        {
            InitializeComponent();
            random = new Random();

        }
        private Color SelectThemeColor()
        {

            int index = random.Next(ThemeColorcs.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColorcs.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColorcs.ColorList[index];
            return ColorTranslator.FromHtml(color);
        } // color choose random not dupplicate

        private void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    // currentButton.Font = new System.Drawing.Font("");
                    currentButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColorcs.ChangeColorBrightness(color, -0.3);
                    ThemeColorcs.PrimaryColor = color;
                    ThemeColorcs.SecondaryColor = ThemeColorcs.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {

                    previousBtn.BackColor = SystemColors.ActiveCaption;
                    //   previousBtn.BackColor = Color.FromArgb(255, 255, 255);

                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }



            }
        }
        private void OpenChildfrom(Form childform, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbTitle.Text = childform.Text;

        }

        private void btnAssignServicetoStaff_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new AdminAssignServiceToStaffs(), sender);

        }

        private void btnAdminViewServiceDetails_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new AdminViewServiceDetails(), sender);

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new StaffManagement(), sender);

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            // Create and show a new instance of MainMenu

            getAdmin = null;
 //           MainMenu f = new MainMenu();
            this.Dispose();
   //         f.ShowDialog();

        }

        private void btnCustomerManagent_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new CustomerManagement(), sender);

        }

        public void CloseChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseChildForms();
            LoginForm login = new LoginForm();  
            login.Show();
            this.Close();

        }


        /* private void lbTitle_Click(object sender, EventArgs e)
         {

         }

         private void btnCustomerManagement_Click(object sender, EventArgs e)
         {
             OpenChildfrom(new Admin.frmCustomerManagement(), sender);

         }

         private void btnStaffManagement_Click(object sender, EventArgs e)
         {
             OpenChildfrom(new Admin.StaffManagement(), sender);

         }

         private void btnCart_Click(object sender, EventArgs e)
         {

             OpenChildfrom(new Admin.StaffOrderManagement(), sender);
         }

         private void btnLogOut_Click(object sender, EventArgs e)
         {
             OpenChildfrom(new Login(), sender);


         }*/

        /*
      


        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new Customer.ProfileManagement(), sender);


        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new Customer.ProductDetail(), sender);


        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);


        }



        private void Login_Click(object sender, EventArgs e)
        {
            //if(btnLogin.Text == "Login") { }
            OpenChildfrom(new Login(), sender);

        }

        private void btnResgiter_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new Customer.Register(), sender);

        }
    }
}

         */
    }
}
