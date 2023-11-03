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

namespace StudentHouseProject.AdminAPage
{
    public partial class AdminCheckOrder : Form
    {
        public AdminCheckOrder()
        {
            InitializeComponent();
        }
        IOrderRepository repository = new OrderRepository();
        public void LoadOrderList()
        {
            try
            {
                var ServiceList = repository.GetOrders();
                BindingSource source = new BindingSource();
                source.DataSource = ServiceList;


                dgvOrder.DataSource = null;
                dgvOrder.DataSource = source;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Services");
            }
        }




        private int GetSelectedCUstomerID()
        {

            int rowIndex = dgvOrder.CurrentCell.RowIndex;
            int row = (int)dgvOrder.Rows[rowIndex].Cells["CustomerId"].Value;
            return row;
        }
        private int GetSelectedProductID()
        {

            int rowIndex = dgvOrder.CurrentCell.RowIndex;
            int row = (int)dgvOrder.Rows[rowIndex].Cells["OrderId"].Value;
            return row;
        }
        IOrderRepository repository_Order = new OrderRepository();
        ICustomerRepository repository_Customer = new CustomerRepository();

        private void LoadOrderDetails(int orderId)
        {
            // Code load OrderDetails dựa vào OrderId
            List<OrderDetail> getOrderDetails = repository_Order.GetOrderDetails(orderId);
            BindingSource source = new BindingSource();
            source.DataSource = getOrderDetails;


            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = source;
        }

        private void LoadCustomer(int customerId)
        {
            int CustomerId = GetSelectedCUstomerID();
            BindingSource source = new BindingSource();
            Customer getCustomer = repository_Customer.GetCustomerById(CustomerId);
            source.DataSource = getCustomer;
            dgvCustomer.DataSource = new List<Customer> { getCustomer };

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // txtAdress.DataBindings.Add("Text", source, "Telephone");



        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int OrderId = GetSelectedProductID();

            int CustomerId = GetSelectedCUstomerID();

            LoadOrderDetails(OrderId);
            LoadCustomer(CustomerId);

        }
    }
}
