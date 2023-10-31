using BusinessObjects;

namespace DataAccessObjects
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();

        private StaffDAO() { }

        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }
        public List<staff> GetStaffs()
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.staff.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public staff GetStaffById(int id)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.staff.Find(id);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddStaff(staff staff)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.staff.Add(staff);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateStaff(staff staff)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    var staffToUpdate = context.staff.Find(staff.StaffId);
                    {
                        staffToUpdate.StaffName = staff.StaffName;
                        staffToUpdate.Email = staff.Email;
                        staffToUpdate.Phone = staff.Phone;
                        staffToUpdate.Dob = staff.Dob;
                        staffToUpdate.Sex = staff.Sex;
                        staffToUpdate.Status = staff.Status;
                        staffToUpdate.ServiceId = staff.ServiceId;

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteStaff(staff staff)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    var staffToDelete = context.staff.Find(staff.StaffId);
                    context.staff.Remove(staffToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
