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
            txtAddress.Enabled = false;
            txtOrderDay.Enabled = false;
            txtPayment.Enabled = false;
            txtPhone.Enabled = false;


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
            // dgvOrderDetails.Columns.Remove("Payments");



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
            dgvViewDetails.Columns.Remove("EndDate");
            dgvViewDetails.Columns.Remove("PaymentMethod");
            dgvViewDetails.Columns.Remove("Id");
            dgvViewDetails.Columns.Remove("Phone");
            dgvViewDetails.Columns.Remove("Order");
            dgvViewDetails.Columns.Remove("Service");
            dgvViewDetails.Columns.Remove("ServiceId");
            dgvViewDetails.Columns.Remove("Address");

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




        }
        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = GetselecttedOrderId();
            loadProductDetails(orderId);

        }
    }
}
