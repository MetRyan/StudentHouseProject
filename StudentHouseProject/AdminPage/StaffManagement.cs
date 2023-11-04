using BusinessObjects;
using Microsoft.VisualBasic.Devices;
using Repositories;

namespace UI.AdminPage
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
        }
        IStaffRepository repository = new StaffRepository();
        BindingSource source;


        public void LoadStaffList()
        {
            txtStaffId.Enabled = false;
            txtStaffName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtdob.Enabled = false;
            txtSex.Enabled = false;
            txtStatus.Enabled = false;
            txtServiceId.Enabled = false;

            btnSearch.Enabled = true;
            cbSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            try
            {
                var StaffList = repository.GetStaffs();
                BindingSource source = new BindingSource();
                source.DataSource = StaffList;

                txtStaffId.DataBindings.Clear();
                txtStaffName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtdob.DataBindings.Clear();
                txtSex.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtServiceId.DataBindings.Clear();



                txtStaffId.DataBindings.Add("Text", source, "StaffId");
                txtStaffName.DataBindings.Add("Text", source, "StaffName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtdob.DataBindings.Add("Text", source, "Dob");
                txtSex.DataBindings.Add("Text", source, "Sex");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtServiceId.DataBindings.Add("Text", source, "Service");

                // txtAdress.DataBindings.Add("Text", source, "Telephone");

                dgv.DataSource = null;
                dgv.DataSource = source;
                if (StaffList.Count < 0) { 
                btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSearch  .Enabled = false;
                    cbSearch.Enabled = false;
                
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            txtStaffId.Enabled = false;
            txtStaffName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtdob.Enabled = false;
            txtSex.Enabled = false;
            txtStatus.Enabled = false;
            txtServiceId.Enabled = false;

            btnSearch.Enabled = false;
            cbSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void reset()
        {
            txtStaffId.Text = "";
            txtStaffName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtdob.Text = "";
            txtSex.Text = "";
            txtPhone.Text = "";
            txtServiceId.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStaffList();


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StaffDetail frm = new StaffDetail()
            {
                InserorUpdate = false,
            };
            if (frm.ShowDialog() == DialogResult.OK) ;
            {
                LoadStaffList();

            }
        }
        private int GetselecttedStaffId()
        {

            int rowIndex = dgv.CurrentCell.RowIndex;
            int row = (int)dgv.Rows[rowIndex].Cells["StaffId"].Value;
            return row;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<staff> CustomerList = repository.GetStaffs().ToList();
            DialogResult d;
            if (CustomerList.Count == 0)
            {
                btnDelete.Enabled = false;
                return;
            }
            d = MessageBox.Show("Are you sure delete it", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (d == DialogResult.OK)
            {

                var StaffId = GetselecttedStaffId();
                staff staffObject = repository.GetStaffById(StaffId);
                repository.DeleteStaff(staffObject);
                LoadStaffList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StaffDetail frm = new StaffDetail()
            {
                InserorUpdate = true,
                getStaffId = GetselecttedStaffId(),
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStaffList();

            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
         

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            String searchBy = cbSearch.Text as string;
            DialogResult d;
            if (searchBy == null)
            {

                d = MessageBox.Show("Please choose field", "Error Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return;
            }
            else
            {

                dgv.DataSource = repository.GetStaffbyStatus(searchBy);
                var result = repository.GetStaffbyStatus(searchBy);
                MessageBox.Show("Tìm thấy " + result.Count + " kết quả!");
            }
        }
    }
}
