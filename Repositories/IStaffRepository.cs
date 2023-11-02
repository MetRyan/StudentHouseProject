using BusinessObjects;
using DataAccessObjects.ResponseModel;

namespace Repositories
{
    public interface IStaffRepository
    {
        public List<staff> GetStaffs();
        public staff GetStaffById(int id);
        public void AddStaff(staff staff);
        public void UpdateStaff(staff staff);
        public void DeleteStaff(staff staff);

        public List<StaffOrderModel> GetStaffOrder(int staffId);
        public List<OrderDetail> GetStaffOrderDetails(int orderId);
        
        public bool CheckloginforStaff(string email, string password);
        public staff getStaffbyEmails(string email);
        public Boolean StaffIdExists (int id);
        public List<staff> GetStaffbyStatus(string Status);

    }
}
