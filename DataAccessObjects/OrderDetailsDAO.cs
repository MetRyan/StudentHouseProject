using BusinessObjects;

namespace DataAccessObjects
{
    public class OrderDetailsDAO
    {
        private static OrderDetailsDAO instance;
        private static object instanceLock = new object();
        public static OrderDetailsDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailsDAO();
                    }
                    return instance;
                }
            }
        }
        public List<OrderDetail> GetAllOrders()
        {
            using (var context = new StudentHouseMembershipContext())
            {
                return context.OrderDetails.ToList();
            }
        }
        public List<OrderDetail> GetOrderDetailsByOrderID(int orderID)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                return context.OrderDetails.Where(od => od.OrderId == orderID).ToList();
            }
        }
        public List<OrderDetail> GetOrderDetailsByServiceID(int serviceID)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                return context.OrderDetails.Where(od => od.ServiceId == serviceID).ToList();
            }
        }
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                context.OrderDetails.Update(orderDetail);
                context.SaveChanges();
            }
        }
        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                context.OrderDetails.Remove(orderDetail);
                context.SaveChanges();
            }
        }
    }
}
