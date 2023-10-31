using BusinessObjects;

namespace Repositories.Interface
{
    public interface IStaffRepository
    {
        public List<staff> GetStaffs();
        public staff GetStaffById(int id);
        public void AddStaff(staff staff);
        public void UpdateStaff(staff staff);
        public void DeleteStaff(staff staff);
        public Boolean CheckloginforStaff(String email, string password);
        public staff getStaffbyEmails(String email);


    }
}
