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
using DataAccessObjects;

namespace StudentHouseProject.StaffPage
{
    public partial class StaffHome : Form
    {
        private staff _staff;
        private List<StaffOrderModel> ordersOfStaff;
        IStaffRepository repository_Staff = new StaffRepository();
        IOrderDetailsRepository orderDetailsRepository = new OrderDetailsRepository();
        IOrderRepository orderRepository = new OrderRepository();

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
            order = order.OrderByDescending(o => o.OrderId).ToList();

            ordersOfStaff = order;

            //Show data in dataGridView
            dgvStaff.DataSource = order;
            dgvStaff.Columns.Remove("orderDetails");

            using (var context = new StudentHouseMembershipContext()) // Replace YourDbContext with your actual DbContext
            {
                foreach (var staffOrder in order)
                {


                    // Check if all OrderDetails have Pending set to True
                    bool allPendingTrue = staffOrder.OrderDetails.All(detail => detail.Pending == "true");
                    Order getOrder = orderRepository.getOrerById(staffOrder.OrderId);

                    if (allPendingTrue)
                    {
                        context.Entry(getOrder).State = EntityState.Detached;

                        getOrder.Inprocess = "true";
                        // Set the Status based on the condition
                        staffOrder.Status = "Done";
                        staff.Status = "false";

                        context.Entry(getOrder).State = EntityState.Modified;
                        context.SaveChanges();

                        context.Entry(staff).State = EntityState.Modified;

                        // Update the staffOrder in the database
                        context.SaveChanges();

                    }
                    else
                    {
                        // Set the Status based on the condition
                        staffOrder.Status = "Pending";
                        getOrder.Inprocess = "false";
                        context.Entry(getOrder).State = EntityState.Modified;

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
