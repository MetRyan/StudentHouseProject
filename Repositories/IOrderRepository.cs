using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        //Session

        public bool AddToCartSession (Service p);
        public bool RemoveFromCartSession(int productId);
        public List<CartItems> getCartsSession();
        //cung cap gio hang
        public int GenerateNewOrderId();
        //Add vao Order detail
        public void AddOrder(OrderDetail order);
        public List<OrderDetail> GetOrderDetails(int id);
        public Order getOrerById(int productId);

        public int addOrder_getOrderId(Order p);
        public List<int> getOrderIdStatusFalse( );

    }
}
