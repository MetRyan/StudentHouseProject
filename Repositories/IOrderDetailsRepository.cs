using BusinessObjects;

namespace Repositories
{
    public interface IOrderDetailsRepository
    {
        public List<OrderDetail> GetAllOrders();
        public List<OrderDetail> GetOrderDetailsByOrderID(int orderID);
        public OrderDetail GetOrderDetailsByServiceID(int serviceID);
        public void UpdateOrderDetail(OrderDetail orderDetail);
        public void DeleteOrderDetail(OrderDetail orderDetail);
    }
}
