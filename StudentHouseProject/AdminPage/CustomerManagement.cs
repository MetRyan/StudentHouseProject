using BusinessObjects;
using Repositories;

namespace UI.AdminPage
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }
        BindingSource source;

        ICustomerRepository repository = new CustomerRepository();
        public void LoadCustomerList()
        {

            txtCustomerID.Enabled = false;
            txtPhone.Enabled = false;
            txtDateOfBirth.Enabled = false;
            txtDateCreated.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastname.Enabled = false;
            txtSex.Enabled = false;
            txtEmail.Enabled = false;

            btnDelete.Enabled = true;
            //btnUpdate.Enabled = true;
            cbSearch.Enabled = true;
            txtSearch.Enabled = true;
            btnSearch.Enabled = true;
            txtAdress.Enabled = false;

            dgvlistview.ReadOnly = true;

            try
            {
                var CustomerList = repository.GetCustomers();
                /* BindingSource source = new BindingSource();
                 source.DataSource = CustomerList;*/
                BindingSource source = new BindingSource();
                source.DataSource = CustomerList;

                txtCustomerID.DataBindings.Clear();
                /* txtDateCreated.DataBindings.Clear();*/
                txtDateOfBirth.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtLastname.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtSex.DataBindings.Clear();
                txtAdress.DataBindings.Clear();


                txtCustomerID.DataBindings.Add("Text", source, "CustomerId");
                /*txtDateCreated.DataBindings.Add("Text", source, "DateCreated");*/
                txtDateOfBirth.DataBindings.Add("Text", source, "Dob");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtFirstName.DataBindings.Add("Text", source, "FirstName");
                txtLastname.DataBindings.Add("Text", source, "LastName");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtSex.DataBindings.Add("Text", source, "Sex");
                txtAdress.DataBindings.Add("Text", source, "Adress");


                dgvlistview.DataSource = null;
                dgvlistview.DataSource = source;
                dgvlistview.Columns.Remove("Password");
                dgvlistview.Columns.Remove("Status");
                dgvlistview.Columns.Remove("Orders");



                //  List<CustomerManagement> Customer = repository.GetCustomer();
                /*                if (Customer.Count == 0)
                                {
                                    btnSearch.Enabled = false;
                                    txtSearch.Enabled = false;
                                    cbSearchType.Enabled = false;
                                    btnDelete.Enabled = false;
                                    btnUpdate.Enabled = false;

                                }
                                else
                                {

                                    btnSearch.Enabled = true;
                                    txtSearch.Enabled = true;
                                    cbSearchType.Enabled = true;
                                    btnDelete.Enabled = true;
                                    btnUpdate.Enabled = true;
                                }*/


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }


        }
        private void reset()
        {
            txtCustomerID.Text = "";
            txtDateCreated.Text = "";
            txtDateOfBirth.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastname.Text = "";
            txtPhone.Text = "";
            txtSex.Text = "";
            txtAdress.Text = "";



        }
        //------------------------------------------------------------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {

            List<Customer> CustomerList = repository.GetCustomers().ToList();
            DialogResult d;

            if (CustomerList.Count == 0)
            {
                btnDelete.Enabled = false;
                return;
            }
            d = MessageBox.Show("Are you sure delete it", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (d == DialogResult.OK)
            {

                var CustomerId = GetSelectedCUstomerID();
                Customer CustomerObject = repository.GetCustomerById(CustomerId);
                repository.DeleteCustomer(CustomerObject);
                LoadCustomerList();
            }
        }
        private int GetSelectedCUstomerID()
        {

            int rowIndex = dgvlistview.CurrentCell.RowIndex;
            int row = (int)dgvlistview.Rows[rowIndex].Cells["CustomerId"].Value;
            return row;
        }

        //bang Customer  chắc admin không cần tạo create -> mà trang Staff sẽ Create 
        /*  private void btnCreate_Click(object sender, EventArgs e)
          {
              frmCardetail frmCreateCar = new frmCardetail()
              {
                  InserorUpdate = false,
              };
              if (frmCreateCar.ShowDialog() == DialogResult.OK) ;
              {
                  LoadCarList();

              }

          }*/
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvlistview.Rows.Count > 0)
            {
                if (dgvlistview.ReadOnly == true)
                {
                    dgvlistview.ReadOnly = false;


                    dgvlistview.DefaultCellStyle.BackColor = Color.Aquamarine;

                }
                else
                {
                    dgvlistview.ReadOnly = true;

                    dgvlistview.DefaultCellStyle.BackColor = Color.White;
                    int getCustomerId = GetSelectedCUstomerID();
                    Customer getObject = repository.GetCustomerById(getCustomerId);
                    repository.UpdateCustomer(getObject);
                    LoadCustomerList();
                }

            }
        }
        /* public List<CarInformation> SearchByType(String keyword, String searchBy)

         {
             searchBy = cbSearchType.Text;
             keyword = txtSearch.Text;
             return repository.SearchCarbyType(keyword, searchBy);

         }*/


        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text;
            String searchBy = cbSearch.SelectedItem as string;

            DialogResult d;
            if (keyword == null || searchBy == null)
            {

                d = MessageBox.Show("Please enter 2 field", "Error Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return;
            }
            if (!string.IsNullOrEmpty(keyword) && !string.IsNullOrEmpty(searchBy))
            {

                dgvlistview.DataSource = repository.SearchCustomerbyType(keyword, searchBy);
                var result = repository.SearchCustomerbyType(keyword, searchBy);
                MessageBox.Show("Tìm thấy " + result.Count + " kết quả!");
            }


        }

        /* private void btnCarManament_Click(object sender, EventArgs e)
         {
             frmCustomerManagment frm = new frmCustomerManagment();
             this.Hide();
             frm.ShowDialog();

         }*/

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            List<Customer> carlist = repository.GetCustomers().ToList();
            DialogResult d;

            d = MessageBox.Show("Are you sure delete it", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (d == DialogResult.OK)
            {

                var customerId = GetSelectedCUstomerID();
                Customer CustomerObject = repository.GetCustomerById(customerId);
                repository.DeleteCustomer(CustomerObject);
                LoadCustomerList();
            }



        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            cbSearch.Enabled = false;
            txtAdress.Enabled = false;
            txtCustomerID.Enabled = false;
            txtDateCreated.Enabled = false;
            txtDateOfBirth.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastname.Enabled = false;
            txtPhone.Enabled = false;
            txtSex.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }



}
