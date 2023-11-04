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
using DataAccessObjects.ResponseModel;
using BusinessObjects;

namespace StudentHouseProject.StaffPage
{
    public partial class StaffHome : Form
    {
        private staff _staff;
        private List<StaffOrderModel> ordersOfStaff;
        IStaffRepository repository_Staff = new StaffRepository();

        public StaffHome(staff staff)
        {
            InitializeComponent();
            _staff = staff;
        }

        private void StaffHome_Load(object sender, EventArgs e)
        {
            LoadData(_staff);
        }

        private void LoadData(staff staff)
        {
            //Take Orders Of Staff
            List<StaffOrderModel> order = repository_Staff.GetStaffOrder(staff.StaffId);
            ordersOfStaff = order;

            //Show data in dataGridView
            dgvStaff.DataSource = order;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                var orderId = (int)dgvStaff.SelectedRows[0].Cells[1].Value;

                StaffViewServiceDetails staffViewServiceDetails = new StaffViewServiceDetails(orderId, _staff);
                staffViewServiceDetails.Show();
                this.Hide();
            }
        }

        private void StaffHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
