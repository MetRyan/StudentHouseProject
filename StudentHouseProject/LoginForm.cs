using BusinessObjects;
using Repositories;
using StudentHouseProject.StaffPage;
using UI;

namespace StudentHouseProject
{
    public partial class LoginForm : Form
    {
        private Form _previousForm = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        ICustomerRepository repository_Customer = new CustomerRepository();
        IStaffRepository repository_Staff = new StaffRepository();
        IAdminRepository repository_Admin = new AdminRepository();

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //check validation 
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required!", "Login Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com.", "User Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //check admin 
                Boolean checkAdmin = repository_Admin.CheckloginforAdmin(txtEmail.Text, txtPassword.Text);
                string email = txtEmail.Text;

                if (checkAdmin)
                {
                    //admin thanh cong

                    /*this.Hide();
                    {
                        getAdmin = getAdminbyEmail,
                    };
                    f.ShowDialog();
                    f.Close();

*/

                    this.Close();

                    Admin getAdminbyEmail = repository_Admin.getAdminbyEmail(email);
                    MainMenuAdmin f = new MainMenuAdmin() { getAdmin = getAdminbyEmail };
                    //  f.ShowDialog();
                    /*     UserHome userHome = new UserHome()

                         {
                             getCustomer = getCustomerbyEmail,
                         };*/

                    // Trong class kh�c
                    f.WindowState = FormWindowState.Maximized;

                    this.Dispose();
                    // Trong class kh�c

                    // Trong class kh�c
                    f.ShowDialog();

                    f.Close();
                }
                else
                {
                    // check staff
                    Boolean checkStaff = repository_Staff.CheckloginforStaff(txtEmail.Text, txtPassword.Text);
                    if (checkStaff)
                    {
                        //staff thanh cong 
                        staff staff = repository_Staff.getStaffbyEmails(email);
                        StaffHome staffHomePage = new StaffHome(staff);
                        ClosePreviousForm();

                        staffHomePage.Show();

                        this.Hide();

                    }
                    else
                    {
                        Boolean checkCustomer = repository_Customer.CheckloginforCustomer(txtEmail.Text, txtPassword.Text);

                        if (checkCustomer)
                        {
                            //this.Close();

                            this.Hide();
                            Customer getCustomerbyEmail = repository_Customer.getCustomerbyEmail(email);
                            MainMenu f = new MainMenu() { getCustomer = getCustomerbyEmail, };
                            //f.btnHomepage_Click(null, null);
                            /*     UserHome userHome = new UserHome()

                                 {
                                     getCustomer = getCustomerbyEmail,
                                 };*/
                            ClosePreviousForm();

                            // Trong class kh�c


                            // f.ShowDialog(); f.Close();  
                            //  Application.run(f);
                            f.WindowState = FormWindowState.Maximized;

                            // Trong class kh�c
                            this.Hide();
                            f.ShowDialog();




                        }
                        else
                        {

                            MessageBox.Show("Invalid Account", "Login Management",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }

                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}