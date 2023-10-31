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
    }
}
