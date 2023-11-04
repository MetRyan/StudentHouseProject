using BusinessObjects;
using Repositories;
namespace UI.AdminPage
{
    public partial class StaffDetail : Form
    {

        public bool InserorUpdate { get; set; }
        public int getStaffId { get; set; }



        IStaffRepository repository = new StaffRepository();

        public StaffDetail()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void StaffDetail_Load(object sender, EventArgs e)
        {
            if (InserorUpdate)
            {


                staff getStaff = repository.GetStaffById(getStaffId);

                txtStaffId.DataBindings.Add("Text", getStaff, "StaffId");
                txtStaffName.DataBindings.Add("Text", getStaff, "StaffName");
                txtEmail.DataBindings.Add("Text", getStaff, "Email");
                txtPhone.DataBindings.Add("Text", getStaff, "Phone");
                dtpdob.DataBindings.Add("Text", getStaff, "Dob");
                cbSex.DataBindings.Add("Text", getStaff, "Sex");
                cbStatus.DataBindings.Add("Text", getStaff, "Status");
                // txtAdress.DataBindings.Add("Text", getStaff, "Address");
                txtPassword.DataBindings.Add("Text", getStaff, "Password");

                // validatoin -> khi input bi loi khong hien new input
                txtStaffId.CausesValidation = false;
                txtStaffName.CausesValidation = false;
                txtEmail.CausesValidation = false;
                txtPhone.CausesValidation = false;
                dtpdob.CausesValidation = false;
                cbStatus.CausesValidation = false;
                //   txtAdress.CausesValidation = false;
                txtPassword.CausesValidation = false;
                cbSex.CausesValidation = false;

                /*           txtCarName.DataBindings.Add("Text", car, "CarName", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarDescription.DataBindings.Add("Text", car, "CarDescription", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtNumberOfDoor.DataBindings.Add("Text", car, "NumberOfDoors", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtSeatingCapacity.DataBindings.Add("Text", car, "SeatingCapacity", false, DataSourceUpdateMode.OnPropertyChanged);
                           cbFuelType.DataBindings.Add("Text", car, "FuelType", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtManufacturer.DataBindings.Add("Text", car, "ManufacturerId", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtSupplierID.DataBindings.Add("Text", car, "SupplierId", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarStatus.DataBindings.Add("Text", car, "CarStatus", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarRenting.DataBindings.Add("Text", car, "CarRentingPricePerDay", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtYear.DataBindings.Add("Text", car, "Year", false, DataSourceUpdateMode.OnPropertyChanged); ;*/

            }
        }


        // Get a list of existing staff IDs

        // Generate a new unique StaffId


        private void btnSave_Click(object sender, EventArgs e)
        {

            /* txtStaffId.DataBindings.Add("Text", getStaff, "StaffId");
             txtStaffName.DataBindings.Add("Text", getStaff, "StaffName");
             txtEmail.DataBindings.Add("Text", getStaff, "Email");
             txtPhone.DataBindings.Add("Text", getStaff, "Phone");
             dtpdob.DataBindings.Add("Text", getStaff, "Dob");
             cbSex.DataBindings.Add("Text", getStaff, "ManufaSexcturerId");
             cbStatus.DataBindings.Add("Text", getStaff, "Status");
             txtAdress.DataBindings.Add("Text", getStaff, "Address");
             txtPassword.DataBindings.Add("Text", getStaff, "Password");*/
            try
            {
                if (
                    txtStaffId.Text == "" &&
                    txtStaffName.Text == ""
                    || txtEmail.Text == "" || txtPhone.Text == "" || dtpdob.Text == ""
                    || cbSex.Text == "" || cbStatus.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Staff Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int staffId = int.Parse(txtStaffId.Text); // Parse the StaffId from the text box

                    if (InserorUpdate == false)
                    {
                        bool staffIdExists = repository.StaffIdExists(staffId);
                        if (staffIdExists)
                        {
                            MessageBox.Show("Staff with the same ID already exists in the database.", "Staff Management",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    int staffIdd;

                    if (!int.TryParse(txtStaffId.Text, out staffIdd))
                    {
                        MessageBox.Show("StaffId must be a valid integer.", "Staff Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (staffId < 1)
                    {
                        MessageBox.Show("StaffId must be a positive integer.", "Staff Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (!txtEmail.Text.EndsWith("@gmail.com"))
                    {
                        MessageBox.Show("Email must end with @gmail.com.", "Staff Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {


                        staff p = new staff
                        {
                            StaffId = int.Parse(txtStaffId.Text),
                            StaffName = txtStaffName.Text,
                            Email = txtEmail.Text,
                            Phone = txtPhone.Text,
                            Dob = dtpdob.Value,
                            Sex = cbSex.Text,
                            Status = cbStatus.Text,
                           // ServiceId = int.Parse(txtServiceId.Text),
                            Password = txtPassword.Text,

                        };



                        if (InserorUpdate == false)
                        {


                            repository.AddStaff(p);
                            MessageBox.Show("Success", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Close();
                        }
                        else
                        {
                            p.StaffId = getStaffId;

                            repository.UpdateStaff(p);
                            MessageBox.Show("Success", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtServiceId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


