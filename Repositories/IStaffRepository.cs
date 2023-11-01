using BusinessObjects;

namespace Repositories
{
    public interface IStaffRepository
    {
        public List<staff> GetStaffs();
        public staff GetStaffById(int id);
        public void AddStaff(staff staff);
        public void UpdateStaff(staff staff);
        public void DeleteStaff(staff staff);
        public bool CheckloginforStaff(string email, string password);
        public staff getStaffbyEmails(string email);
        public Boolean StaffIdExists (int id);

    }
}
