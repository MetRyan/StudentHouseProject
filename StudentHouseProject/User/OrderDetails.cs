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

namespace StudentHouseProject.User
{
    public partial class OrderDetails : Form
    {
        public Customer getCustomer { get; set; }
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            //  btnReload.PerformClick();
            txtAddress.Enabled = false;
            txtOrderDay.Enabled = false;
            txtPayment.Enabled = false;
            txtPhone.Enabled = false;
            var OrderList = repository.GetOrdersByCustomerId(getCustomer.CustomerId);
            BindingSource srouce = new BindingSource();
            srouce.DataSource = OrderList;

            dgvOrderDetails.DataSource = srouce;

            dgvOrderDetails.Columns.Remove("Payments");
            dgvOrderDetails.Columns.Remove("OrderDetails");
            dgvOrderDetails.Columns.Remove("Customer");
            dgvOrderDetails.Columns.Remove("StaffOrders");

            // dgvOrderDetails.Columns.Remove("Payments");
            foreach (var order in OrderList)
            {
                if (order.Status == "true")
                {
                    order.Status = "đã giao việc ";


                }
                else
                {
                    order.Status = "chưa giao việc ";

                }
                if (order.Inprocess == "true")
                {
                    order.Inprocess = " Đã hoàn thành";


                }
                else
                {
                    order.Inprocess = " Chưa hoàn thành";


                }



            }


        }
        IOrderRepository repository = new OrderRepository();

        private void btnReload_Click(object sender, EventArgs e)
        {
            var OrderList = repository.GetOrdersByCustomerId(getCustomer.CustomerId);
            BindingSource srouce = new BindingSource();
            srouce.DataSource = OrderList;

            dgvOrderDetails.DataSource = srouce;

            dgvOrderDetails.Columns.Remove("Payments");
            dgvOrderDetails.Columns.Remove("OrderDetails");
            dgvOrderDetails.Columns.Remove("Customer");
            dgvOrderDetails.Columns.Remove("StaffOrders");

            // dgvOrderDetails.Columns.Remove("Payments");
            foreach (var order in OrderList)
            {
                if (order.Status == "true")
                {
                    order.Status = "đã giao việc ";


                }
                else
                {
                    order.Status = "chưa giao việc ";

                }
                if (order.Inprocess == "true")
                {
                    order.Inprocess = " Đã hoàn thành";


                }
                else
                {
                    order.Inprocess = " Chưa hoàn thành";


                }



            }


        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int GetselecttedOrderId()
        {

            int rowIndex = dgvOrderDetails.CurrentCell.RowIndex;
            int row = (int)dgvOrderDetails.Rows[rowIndex].Cells["OrderId"].Value;
            return row;
        }
        private void loadProductDetails(int OrderId)
        {
            List<OrderDetail> getOrderDetails = repository.GetOrderDetails(OrderId);
            BindingSource source = new BindingSource();
            source.DataSource = getOrderDetails;


            dgvViewDetails.DataSource = null;
            dgvViewDetails.DataSource = source;
            //EndDate//PaymemmtMethod,Id,Phone,Order,Service,endday


            txtAddress.DataBindings.Clear();
            txtOrderDay.DataBindings.Clear();
            txtPayment.DataBindings.Clear();
            txtPhone.DataBindings.Clear();

            txtAddress.DataBindings.Add("Text", getOrderDetails, "Address");
            txtOrderDay.DataBindings.Add("Text", getOrderDetails, "CreateDate");
            txtPayment.DataBindings.Add("Text", getOrderDetails, "PaymentMethod");
            txtPhone.DataBindings.Add("Text", getOrderDetails, "Phone");

            dgvViewDetails.DataSource = null;
            dgvViewDetails.DataSource = source;
            dgvViewDetails.Columns.Remove("EndDate");
            dgvViewDetails.Columns.Remove("PaymentMethod");
            dgvViewDetails.Columns.Remove("Id");
            dgvViewDetails.Columns.Remove("Phone");
            dgvViewDetails.Columns.Remove("Order");
            dgvViewDetails.Columns.Remove("Service");
            dgvViewDetails.Columns.Remove("ServiceId");
            dgvViewDetails.Columns.Remove("Address");
            // foreach( var )
            foreach (var items in getOrderDetails)
            {

                if (items.Pending == "true")
                {
                    items.Pending = " đã hoàn thành";

                }
                else
                {

                    items.Pending = " chưa hoàn thành ";
                }

            }


        }
        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = GetselecttedOrderId();
            loadProductDetails(orderId);

        }
    }
}
