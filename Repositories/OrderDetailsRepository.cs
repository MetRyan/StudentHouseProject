using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        public void DeleteOrderDetail(OrderDetail orderDetail) => OrderDetailsDAO.Instance.DeleteOrderDetail(orderDetail);

        public List<OrderDetail> GetAllOrders() => OrderDetailsDAO.Instance.GetAllOrders();

        public List<OrderDetail> GetOrderDetailsByOrderID(int orderID) => OrderDetailsDAO.Instance.GetOrderDetailsByOrderID(orderID);

        public List<OrderDetail> GetOrderDetailsByServiceID(int serviceID) => OrderDetailsDAO.Instance.GetOrderDetailsByServiceID(serviceID);

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailsDAO.Instance.UpdateOrderDetail(orderDetail);
        }
    }
}
