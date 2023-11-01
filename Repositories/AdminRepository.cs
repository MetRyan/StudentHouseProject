using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public void AddAdmin(Admin admin) => AdminDAO.Instance.AddAdmin(admin);

        public Boolean CheckloginforAdmin(string email, string password) => AdminDAO.CheckLoginforAdmin(email, password);

        public void DeleteAdmin(Admin admin) => AdminDAO.Instance.DeleteAdmin(admin);

        public Admin GetAdminById(int id) => AdminDAO.Instance.GetAdminById(id);

        public List<Admin> GetAdmins() => AdminDAO.Instance.GetAdmins();
        public void UpdateAdmin(Admin admin) => AdminDAO.Instance.UpdateAdmin(admin);


        public Admin getAdminbyEmail(string email) => AdminDAO.GetAdminbyEmail(email);
    }
}
