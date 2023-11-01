using BusinessObjects;

namespace Repositories
{
    public interface IStaffOrderRepository
    {
        public List<StaffOrder> StaffOrders { get; }

        public void AddStaffOrder(StaffOrder staffOrder);

    }
}
