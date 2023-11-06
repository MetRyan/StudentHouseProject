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
using Microsoft.EntityFrameworkCore;

namespace StudentHouseProject.StaffPage
{
    public partial class StaffHome : Form
    {
        private staff _staff;
        private List<StaffOrderModel> ordersOfStaff;
        IStaffRepository repository_Staff = new StaffRepository();
        IOrderDetailsRepository orderDetailsRepository = new OrderDetailsRepository();

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
            dgvStaff.Columns.Remove("orderDetails");

            using (var context = new StudentHouseMembershipContext()) // Replace YourDbContext with your actual DbContext
            {
                foreach (var staffOrder in order)
                {
                    // Check if all OrderDetails have Pending set to True
                    bool allPendingTrue = staffOrder.OrderDetails.All(detail => detail.Pending == true);

                    if (allPendingTrue)
                    {
                        // Set the Status based on the condition
                        staffOrder.Status = "Done";

                        // Update the staffOrder in the database
                        context.SaveChanges();

                    }
                    else
                    {
                        // Set the Status based on the condition
                        staffOrder.Status = "Pending";

                        // Update the staffOrder in the database
                        context.SaveChanges();

                    }
                }

                // Save changes to the database
            }

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
            /*   LoginForm login = new LoginForm();
               login.Show();*/
            this.Hide();
        }
    }
}
