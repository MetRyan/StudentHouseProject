using BusinessObjects;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static readonly object instanceLock = new object();

        private CustomerDAO() { }

        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Customer> GetCustomers()
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.Customers.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public Customer GetCustomerById(int id)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.Customers.Find(id);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddCustomer(Customer customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateCustomer(Customer customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Customers.Update(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.Customers.Remove(customer);
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