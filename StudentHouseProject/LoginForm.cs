using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Interface;
using UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentHouseProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
                    MainMenuAdmincs f = new MainMenuAdmincs();
                    f.btnHomepage_Click(null, null);
                    /*     UserHome userHome = new UserHome()

                         {
                             getCustomer = getCustomerbyEmail,
                         };*/

                    // Trong class khác

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
                        /*
                                                this.Hide();
                                                staff getstaffbyEmail = repository_Staff.getStaffbyEmails(email);
                                                MainMenuAdmincs f = new MainMenuAdmincs()
                                                {
                                                    getStaff = getstaffbyEmail,
                                                };
                                                f.ShowDialog();
                                                f.Close();
                        */
                    }
                    else
                    {
                        Boolean checkCustomer = repository_Customer.CheckloginforCustomer(txtEmail.Text, txtPassword.Text);

                        if (checkCustomer)
                        {
                            this.Close(); 

                            Customer getCustomerbyEmail = repository_Customer.getCustomerbyEmail(email);
                            MainMenu f = new MainMenu() { getCustomer = getCustomerbyEmail, };
                            f.btnHomepage_Click(null, null);
                            /*     UserHome userHome = new UserHome()

                                 {
                                     getCustomer = getCustomerbyEmail,
                                 };*/

                            // Trong class khác
                  
                            f.ShowDialog();
                           
                            f.Close();

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
    }
}