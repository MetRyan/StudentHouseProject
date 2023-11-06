using BusinessObjects;
using Repositories;

namespace StudentHouseProject.User
{
    public partial class UserProfile : Form
    {
        public Customer getCustomer { get; set; }
        public UserProfile()
        {
            InitializeComponent();
        }
        ICustomerRepository repository = new CustomerRepository();

        private void UserProfile_Load(object sender, EventArgs e)
        {

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            dateTimePicker1.Enabled = false;

            txtPhone.Enabled = false;
            cbSex.Enabled = false;
            txtPassword.Enabled = false;

            txtFirstName.DataBindings.Add("Text", getCustomer, "FirstName");
            txtLastName.DataBindings.Add("Text", getCustomer, "LastName");
            txtAddress.DataBindings.Add("Text", getCustomer, "Adress");
            dateTimePicker1.DataBindings.Add("Text", getCustomer, "Dob");
            txtPhone.DataBindings.Add("Text", getCustomer, "Phone");
            cbSex.DataBindings.Add("Text", getCustomer, "Sex");
            txtPassword.DataBindings.Add("Text", getCustomer, "Password");


            // validatoin -> khi input bi loi khong hien new input
            txtFirstName.CausesValidation = false;
            txtLastName.CausesValidation = false;
            dateTimePicker1.CausesValidation = false;
            txtPhone.CausesValidation = false;
            txtAddress.CausesValidation = false;
            //   txtAdress.CausesValidation = false;
            txtPassword.CausesValidation = false;
            cbSex.CausesValidation = false;


        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (btnSave.Text == "Edit")
            {
                btnSave.Text = "Save";
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtAddress.Enabled = true;
                dateTimePicker1.Enabled = true;

                txtPhone.Enabled = true;
                cbSex.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {


                if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                      string.IsNullOrWhiteSpace(cbSex.Text))
                {
                    MessageBox.Show("All fields are required!", "Registration Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Registration Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtPhone.Text.Length < 9 || txtPhone.Text.Length > 11)
                {
                    MessageBox.Show("Phone number must be between 9 and 11 characters.", "Registration Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!DateTime.TryParse(dateTimePicker1.Text, out var dateOfBirth) || dateOfBirth >= DateTime.Now)
                {
                    MessageBox.Show("Invalid date of birth. Please use a valid date before today.", "Registration Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    Customer p = new Customer()
                    {

                        DateCreated = DateTime.Now,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Dob = dateOfBirth,
                        Phone = txtPhone.Text,
                        Password = txtPassword.Text,
                        Sex = cbSex.Text,
                        Adress = txtAddress.Text,
                        Email = getCustomer.Email,


                    };

                    p.CustomerId = getCustomer.CustomerId;
                    repository.UpdateCustomer(p);
                    MessageBox.Show("Success");
                    btnSave.Text = "Edit";
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtAddress.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    txtPhone.Enabled = false;
                    cbSex.Enabled = false;
                    txtPassword.Enabled = false;
                }


            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}