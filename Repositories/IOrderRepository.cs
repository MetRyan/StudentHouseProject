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
        public OrderDetail GetOrder(int id);

        public int addOrder_getOrderId(Order p);
    }
}
