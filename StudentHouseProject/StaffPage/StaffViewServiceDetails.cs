using BusinessObjects;
using DataAccessObjects.ResponseModel;
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
        private List<OrderDetail> _orderDetails;
        private staff _staff;
        private IStaffRepository repository_Staff;

        public StaffViewServiceDetails(int orderId, staff staff)
        {
            InitializeComponent();
            LoadOrder(orderId);
            _staff = staff;
        }

        private void LoadOrder(int orderId)
        {
            _orderDetails = repository_Staff.GetStaffOrderDetails(orderId);
        }

        private void StaffViewServiceDetails_Load(object sender, EventArgs e)
        { 
            txtServiceName.Text = _orderDetails.FirstOrDefault().ServiceName;
            txtAmountOfTime.Text = _orderDetails.FirstOrDefault().Service.AmountOfTime.ToString();
            txtServicePrice.Text = _orderDetails.FirstOrDefault().Service.Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffHome home = new StaffHome(_staff);
            home.Show();
            this.Hide();
        }
    }
}
