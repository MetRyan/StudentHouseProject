using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(OrderDetail order) => OrderDAOs.AddOrder(order);

        public int addOrder_getOrderId(Order p) => OrderDAOs.AddOrder(p);

        public bool AddToCartSession(Service p) => OrderDAOs.AddToCart(p);

        public int GenerateNewOrderId() => OrderDAOs.GenerateNewOrderId();

        public List<CartItems> getCartsSession() => OrderDAOs.getCartsSession();

        public List <OrderDetail> GetOrderDetails(int id) => OrderDAOs.GetOrderDetailsbyOrderId(id);
        public bool RemoveFromCartSession(int productId) => OrderDAOs.RemoveFromCart(productId);
        public Order getOrerById (int productId) => OrderDAOs.GetOrderbyId(productId);
        public List<int> getOrderIdStatusFalse() => OrderDAOs.getOrderIdPending();
        
        public List<Order> GetOrders ()=> OrderDAOs.GetOrders();
        public List<Order> GetOrdersByCustomerId(int CustomerId) => OrderDAOs.GetOrderbyCustomer(CustomerId);

        
    }
}
