using BusinessObjects;
using DataAccessObjects.ResponseModel;

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
        public static Boolean CheckLoginforStaff(String email, String password)
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
        public static staff GetstaffbyEmail(String email)
        {
            staff getStaff = new staff();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {

                    getStaff = context.staff.SingleOrDefault(m => m.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return getStaff;
        }

        public static List<StaffOrderModel> GetStaffOrder(int staffId)
        {
            try
            {
                using(var context = new StudentHouseMembershipContext())
                {
                    List<StaffOrderModel> result = null;

                    List<StaffOrder> ordersOfStaff = context.StaffOrders.Where(x => x.StaffId == staffId).ToList();

                    foreach(var orderOfStaff in ordersOfStaff)
                    {
                        StaffOrderModel staffOrderModel = null;

                        Order order = context.Orders.Where(x => x.OrderId == orderOfStaff.OrderId).FirstOrDefault();
                        if (order != null)
                        {
                            staffOrderModel.StaffId = staffId;
                            staffOrderModel.OrderId = orderOfStaff.OrderId;
                            staffOrderModel.WorkDate = orderOfStaff.WorkDate;
                            staffOrderModel.Status = orderOfStaff.Status;
                            staffOrderModel.Description = order.Description;
                            staffOrderModel.orderDetails = context.OrderDetails.Where(x => x.OrderId == order.OrderId).ToList();
                        }

                        if(staffOrderModel != null)
                        {
                            result.Add(staffOrderModel);
                        }
                    }

                    return result;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<OrderDetail> GetStaffOrderDetails(int orderId)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.OrderDetails.Where(x => x.OrderId == orderId).ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
