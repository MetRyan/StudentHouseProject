using BusinessObjects;

namespace Repositories.Interface
{
    public interface IAdminRepository
    {
        public List<Admin> GetAdmins();
        public Admin GetAdminById(int id);
        public void AddAdmin(Admin admin);
        public void UpdateAdmin(Admin admin);
        public void DeleteAdmin(Admin admin);
        public Boolean CheckloginforAdmin(String email, string password);
        public Admin getAdminbyEmail(String email);

    }
}
