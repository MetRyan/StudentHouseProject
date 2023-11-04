using BusinessObjects;
using Repositories;
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

namespace StudentHouseProject.AdminAPage
{
    public partial class AdminViewServiceDetails : Form
    {
        public AdminViewServiceDetails()
        {
            InitializeComponent();
        }

        IServiceRepository repository = new ServiceRepository();
        BindingSource source;


        public void LoadServiceList()
        {
            txtServiceId.Enabled = false;
            txtAmountOfTime.Enabled = false;
            txtServiceName.Enabled = false;
            txtServicePrice.Enabled = false;
            txtStatus.Enabled = false;


            btnUpdateService.Enabled = true;
            btnAdd.Enabled = true;
            btnDeleteService.Enabled = true;
            try
            {
                var ServiceList = repository.GetServices();
                BindingSource source = new BindingSource();
                source.DataSource = ServiceList;

                txtAmountOfTime.DataBindings.Clear();
                txtServiceId.DataBindings.Clear();
                txtServiceName.DataBindings.Clear();
                txtServicePrice.DataBindings.Clear();
                txtStatus.DataBindings.Clear();



                txtServiceId.DataBindings.Add("Text", source, "ServiceId");
                txtServiceName.DataBindings.Add("Text", source, "ServiceName");
                txtAmountOfTime.DataBindings.Add("Text", source, "AmountOfTime");
                txtServicePrice.DataBindings.Add("Text", source, "Price");
                txtStatus.DataBindings.Add("Text", source, "Status");

                // txtAdress.DataBindings.Add("Text", source, "Telephone");

                dgv.DataSource = null;
                dgv.DataSource = source;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Services");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void reset()
        {
            txtAmountOfTime.Text = "";
            txtServiceId.Text = "";
            txtServiceName.Text = "";
            txtServicePrice.Text = "";
            txtStatus.Text = "";
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            AdminServiceDetail frm = new AdminServiceDetail()
            {
                InserorUpdate = false,
            };
            if (frm.ShowDialog() == DialogResult.OK) ;
            {
                LoadServiceList();

            }
        }
        private int GetselecttedStaffId()
        {

            int rowIndex = dgv.CurrentCell.RowIndex;
            int row = (int)dgv.Rows[rowIndex].Cells["ServiceId"].Value;
            return row;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Service> ServiceList = repository.GetServices();
            DialogResult d;
            if (ServiceList.Count == 0)
            {
                btnDeleteService.Enabled = false;
                return;
            }
            d = MessageBox.Show("Are you sure delete it", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (d == DialogResult.OK)
            {

                var StaffId = GetselecttedStaffId();
                Service staffObject = repository.GetServiceById(StaffId);
                repository.DeleteService(staffObject);
                LoadServiceList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var ServiceId = GetselecttedStaffId();
            Service service = repository.GetServiceById(ServiceId);

            AdminServiceDetail frm = new AdminServiceDetail()
            {
                InserorUpdate = true,
                getService = service,
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadServiceList();

            }

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            LoadServiceList();

        }

        private void AdminViewServiceDetails_Load(object sender, EventArgs e)
        {

            txtAmountOfTime.Enabled = false;
            txtServiceId.Enabled = false;
            txtServiceName.Enabled = false;
            txtServicePrice.Enabled = false;
            txtStatus.Enabled = false;


            btnDeleteService.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdateService.Enabled = false;
        }
    }
}
