using BusinessObjects;

namespace DataAccessObjects
{
    public class AdminDAO
    {
        private static AdminDAO instance = null;
        private static readonly object instanceLock = new object();

        private AdminDAO() { }

        public static AdminDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AdminDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Admin> GetAdmins()
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.Admins.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Admin GetAdminById(int id)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.Admins.Find(id);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddAdmin(Admin admin)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Admins.Add(admin);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateAdmin(Admin admin)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Admins.Update(admin);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteAdmin(Admin admin)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Admins.Remove(admin);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public static Boolean CheckLoginforAdmin(String email, String password)
        {
            try
            {
                using (var Context = new StudentHouseMembershipContext())
                {
                    var temp = Context.Admins.SingleOrDefault(p => p.Email == email
                    && p.Password == password);
                    if (temp != null)
                    { return true; }

                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "");

            }




        }
        public static Admin GetAdminbyEmail(String email)
        {
            Admin Admins = new Admin();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {

                    Admins = context.Admins.SingleOrDefault(m => m.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Admins;
        }
    }
}
