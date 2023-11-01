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
        public bool AddToCartSession(Service p) => OrderDAOs.AddToCart(p);

        public List<CartItems> getCartsSession() => OrderDAOs.getCartsSession();

        public bool RemoveFromCartSession(int productId) => OrderDAOs.RemoveFromCart(productId);
    }
}
