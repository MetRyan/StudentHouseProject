using BusinessObjects;
using DataAccessObjects;

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

        }
        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                StaffOrder staffOrder = new StaffOrder();
                staffOrder.StaffId = Convert.ToInt32(cbStaff.Text);
                staffOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
                staffOrder.WorkDate = Convert.ToDateTime(txtWorkDate.Text);
                staffOrder.Status = "Assigned";

                StaffOrderDAO staffOrderDAO = new StaffOrderDAO();
                staffOrderDAO.AddStaffOrder(staffOrder);
                MessageBox.Show("Assign successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
