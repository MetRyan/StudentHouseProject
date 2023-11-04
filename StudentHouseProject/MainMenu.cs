using BusinessObjects;
using StudentHouseProject;
using StudentHouseProject.User;

namespace UI
{
    public partial class MainMenu : Form
    {



        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //getCustomer if login
        public Customer getCustomer { get; set; }

        public MainMenu()
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
        /*    public static void ActivateCartButton(MainMenu form)
            {
                form.btnCart.PerformClick();
            }*/


        /*ublic void ActivateCartButton()
        {
            btnCart.PerformClick();
        }*/
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

        public void btnHomepage_Click(object sender, EventArgs e)
        {

            UserHome userHome = new UserHome();
            userHome.getCustomer = getCustomer;
            // Open the UserHome form
            OpenChildfrom(userHome, sender);
        }

        /*    private void btnProfile_Click(object sender, EventArgs e)
            {
                OpenChildfrom(new Customer.ProfileManagement(), sender);


            }
    */
        /* private void btnCart_Click(object sender, EventArgs e)
         {


         }
 */


        public void button1_Click(object sender, EventArgs e)
        {

            OpenChildfrom(new Carts() { getCustomer = getCustomer }, sender);

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new LoginForm(this), sender);
        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new Register(), sender);

        }
        public void UpdateUIForUserLoggedIn()
        {
            // Check if the Customer property is not null (user is logged in)
            if (getCustomer != null)
            {
                // Hide and disable the Register and Login buttons
                btnRegister.Visible = false;
                btnRegister.Enabled = false;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;
                btnProfile.Visible = true;
                btnProfile.Enabled = true;
                // Show and enable the LogOut button
                btnLogOut.Visible = true;
                btnLogOut.Enabled = true;
                btnOrderHis.Visible = true;
                btnOrderHis.Visible = true;

            }
            else
            {
                // Show and enable the Register and Login buttons
                btnRegister.Visible = true;
                btnRegister.Enabled = true;
                btnLogin.Visible = true;
                btnLogin.Enabled = true;
                btnProfile.Visible = false;
                btnProfile.Enabled = false;

                // Hide and disable the LogOut button
                btnLogOut.Visible = false;
                btnLogOut.Enabled = false;
            }
        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            CloseChildForms();
            // Hide and disable the LogOut button
            UpdateUIForUserLoggedIn();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CloseChildForms();

            getCustomer = null;
            //     this.Close();

            this.Dispose();
            // Create and show a new instance of MainMenu
            MainMenu f = new MainMenu();
            // newMainMenu.ShowDialog();

            //  f.ShowDialog();
            //   CloseChildForms();
            f.Show();
            CloseChildForms();
            this.Close();

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CloseChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            //this.Close();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseChildForms();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildfrom(new UserProfile() { getCustomer = getCustomer }, sender);

        }



        private void btnHistoryOrder(object sender, EventArgs e)
        {
            OpenChildfrom(new OrderDetails() { getCustomer = getCustomer }, sender);

        }
    }
}
