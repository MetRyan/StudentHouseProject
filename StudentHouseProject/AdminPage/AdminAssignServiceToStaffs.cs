using BusinessObjects;
using DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StudentHouseProject.AdminAPage
{
    public partial class AdminAssignServiceToStaffs : Form
    {
        public AdminAssignServiceToStaffs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminAssignServiceToStaffs_Load(object sender, EventArgs e)
        {
            LoadOrderIds();
            LoadStaffIds();
            /*  if (cbStaff.SelectedItem != null)
              {
                  int staffId = (int)cbStaff.SelectedItem;

                  staff getStaff = repository_Staff.GetStaffById(staffId);
                  dgvStaff.DataSource = getStaff;

              }*/
            /*     if (cbOrderId.SelectedItem != null)
                 {

                     int OrderId = (int)cbOrderId.SelectedItem;

                     List<OrderDetail> getOrderDetails = repository_Order.GetOrderDetails(OrderId);
                     MessageBox.Show(getOrderDetails[0].Phone);


                     dgvOrder.DataSource = getOrderDetails;

                     //                dgvStaff.DataSource = getStaff;

                 }*/

        }
        IStaffRepository repository_Staff = new StaffRepository();
        IOrderRepository repository_Order = new OrderRepository();


        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            try
            {
                StaffOrder staffOrder = new StaffOrder();
                staffOrder.StaffId = Convert.ToInt32(cbStaff.Text);
                staffOrder.OrderId = Convert.ToInt32(cbOrderId.Text);
                staffOrder.WorkDate = Convert.ToDateTime(txtWorkDate.Text);
                staffOrder.Status = "Assigned";

                StaffOrderDAO staffOrderDAO = new StaffOrderDAO();
                staffOrderDAO.AddStaffOrder(staffOrder);
                Order getOrder = repository_Order.getOrerById(int.Parse(cbOrderId.Text));
                getOrder.Status = "true";
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Entry(getOrder).State = EntityState.Modified;
                    context.SaveChanges();
                }
                staffOrder.Status = "true";
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Entry(staffOrder).State = EntityState.Modified;
                    context.SaveChanges();
                }
                MessageBox.Show("Assign successfully!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset()
        {
            dgvOrder.DataSource = null;
            dgvStaff.DataSource = null;
            cbOrderId.Text = "";
            cbStaff.Text = "";
            txtWorkDate.Text = "";


        }


        private void LoadOrderIds()
        {
            // Clear and load the order IDs into the ComboBox
            cbOrderId.Items.Clear();

            List<int> orderIds = repository_Order.getOrderIdStatusFalse();

            foreach (var item in orderIds)
            {
                cbOrderId.Items.Add(item);
            }
        }
        private void LoadStaffIds()
        {
            // Clear and load the order IDs into the ComboBox
            cbStaff.Items.Clear();

            List<int> StaffId = repository_Staff.getStaffByAvailable();

            foreach (var item in StaffId)
            {
                cbStaff.Items.Add(item);
            }
        }
        private void cbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStaff.SelectedItem != null)
            {
                int staffId = (int)cbStaff.SelectedItem;
                staff getStaff = repository_Staff.GetStaffById(staffId);
                dgvStaff.DataSource = new List<staff> { getStaff };
                // tra ve 1 cai nen

                //                dgvStaff.DataSource = getStaff;

            }
        }
        private void cbOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbOrderId.SelectedItem != null)
            {

                int OrderId = (int)cbOrderId.SelectedItem;

                List<OrderDetail> getOrderDetails = repository_Order.GetOrderDetails(OrderId);


                dgvOrder.DataSource = getOrderDetails;

                //                dgvStaff.DataSource = getStaff;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
