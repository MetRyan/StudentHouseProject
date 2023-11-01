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


    }
}
