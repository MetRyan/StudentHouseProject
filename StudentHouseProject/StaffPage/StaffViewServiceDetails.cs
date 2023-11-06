using BusinessObjects;
using DataAccessObjects.ResponseModel;
using Microsoft.EntityFrameworkCore;
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

namespace StudentHouseProject.StaffPage
{
    public partial class StaffViewServiceDetails : Form
    {
        private List<OrderDetail> _orderDetails = new List<OrderDetail>();
        private staff _staff;
        private IStaffRepository repository_Staff = new StaffRepository();
        private IServiceRepository repository_Service = new ServiceRepository();
        public IOrderDetailsRepository repository_OrderDetails = new OrderDetailsRepository();
        public StaffViewServiceDetails(int orderId, staff staff)
        {
            InitializeComponent();
            LoadOrder(orderId);
            _staff = staff;
        }
        private bool isInitialLoad = true;


        private void LoadOrder(int orderId)
        {
            /*  _orderDetails = repository_Staff.GetStaffOrderDetails(order-Id);

              foreach (OrderDetail detail in _orderDetails)
              {
                  Service service = repository_Service.GetServiceById((int)detail.ServiceId);
                  detail.Service = service;
              }*/
            List<OrderDetail> getOrderDetails = repository_OrderDetails.GetOrderDetailsByOrderID(orderId);

            txtAddress.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            isInitialLoad = false;
            cbPending.Enabled = false;
            cbStatusWork.Text = "";

            BindingSource source = new BindingSource();
            source.DataSource = getOrderDetails;


            txtAddress.DataBindings.Clear();
            cbPending.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPhone.DataBindings.Clear();



            txtAddress.DataBindings.Add("Text", source, "Address");
            /*txtDateCreated.DataBindings.Add("Text", source, "DateCreated");*/
            cbPending.DataBindings.Add("Text", source, "Pending");
            txtName.DataBindings.Add("Text", source, "ServiceName");
            txtPhone.DataBindings.Add("Text", source, "Phone");

            //dgvProductDetails.DataSource = null;
            dgvProductDetails.DataSource = source;
            dgvProductDetails.Columns.Remove("Order");
            dgvProductDetails.Columns.Remove("Service");
            dgvProductDetails.Columns.Remove("EndDate");




        }

        private void StaffViewServiceDetails_Load(object sender, EventArgs e)
        {


            /* txtServiceName.Text = _orderDetails.FirstOrDefault().ServiceName;
             txtAmountOfTime.Text = _orderDetails.FirstOrDefault().Service.AmountOfTime.ToString();
             txtServicePrice.Text = _orderDetails.FirstOrDefault().Service.Price.ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffHome home = new StaffHome(_staff);
            home.Show();
            this.Hide();
        }

        private void StaffViewServiceDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaffHome home = new StaffHome(_staff);
            home.Show();
            this.Hide();
        }

        private int GetselecttedServiceId()
        {

            int rowIndex = dgvProductDetails.CurrentCell.RowIndex;
            int row = (int)dgvProductDetails.Rows[rowIndex].Cells["ServiceID"].Value;
            return row;
        }
        private int GetselecttedOrderId()
        {

            int rowIndex = dgvProductDetails.CurrentCell.RowIndex;
            int row = (int)dgvProductDetails.Rows[rowIndex].Cells["OrderId"].Value;
            return row;
        }

        private void cbPending_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbStatusWork != null && cbStatusWork.SelectedItem != null)
            {
                // Lấy giá trị SelectedItem
                string selected = cbStatusWork.SelectedItem.ToString();

                // Xử lý
                int OrderId = GetselecttedOrderId();
                string newPendingValue = "true";
                if (cbStatusWork.SelectedItem.ToString() == "True")
                {
                    newPendingValue = "true";
                }
                else if (cbStatusWork.SelectedItem.ToString() == "False")
                {
                    newPendingValue = "false";
                }
                else { return; }

                using (var context = new StudentHouseMembershipContext())
                {

                    int ServiceId = GetselecttedServiceId();

                    OrderDetail orderDetail = context.OrderDetails.FirstOrDefault(o => o.ServiceId == ServiceId && o.OrderId == OrderId);

                    orderDetail.Pending = newPendingValue;
                    context.Entry(orderDetail).State = EntityState.Modified;

                    context.SaveChanges();

                    LoadOrder(OrderId); // Replace ?? with the appropriate argument
                    cbStatusWork.Text = "";

                    // Display a message or perform any other necessary actions
                    MessageBox.Show("Pending status updated successfully.");
                    cbStatusWork.Text = "";
                    cbStatusWork.SelectedIndex = -1;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
