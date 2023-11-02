using BusinessObjects;

namespace DataAccessObjects
{
    public class StaffOrderDAO
    {
        // Singleton pattern
        private static StaffOrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static StaffOrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffOrderDAO();
                    }
                    return instance;
                }
            }
        }
        public List<StaffOrder> StaffOrders()
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.StaffOrders.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //Assign service to staff
        public void AddStaffOrder(StaffOrder staffOrder)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.StaffOrders.Add(staffOrder);
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
