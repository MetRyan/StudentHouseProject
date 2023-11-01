using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class StaffOrderRepository : IStaffOrderRepository
    {
        public void AddStaffOrder(StaffOrder staffOrder)
        {
            StaffOrderDAO.Instance.AddStaffOrder(staffOrder);
        }

        public List<StaffOrder> StaffOrders => StaffOrderDAO.Instance.StaffOrders();
    }
}
