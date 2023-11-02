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
        public static Boolean CheckLoginforCustomer(String email, String password)
        {
            try
            {
                using (var Context = new StudentHouseMembershipContext())
                {
                    var temp = Context.Customers.SingleOrDefault(p => p.Email == email
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
        public static Customer GetCustomerbyEmail(String email)
        {
            Customer Customer = new Customer();
            try
            {
                using (var context = new StudentHouseMembershipContext()) { 
                
                    Customer = context.Customers.SingleOrDefault(m => m.Email == email);
            }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Customer;
        }
        public static List<Customer> SearchByType(String keyword, String Type)
        {

            using (var context = new StudentHouseMembershipContext())

                if (Type == "Phone")
                {
                    try
                    {
                        return context.Customers.Where(p => p.Phone.Contains(keyword)).ToList();
                    }
                    catch (FormatException ex)
                    {
                        // Log error 
                        throw new Exception($"Invalid keyword for Phone: {keyword}", ex);
                        // Throw again or return empty result
                    }
                }
                else if (Type == "Name")
                {
                    try
                    {

                        return context.Customers.Where(p => p.LastName.Contains(keyword)).ToList()
                                .Where(p => p.FirstName.Contains(keyword)).ToList();
                        


                    }
                    catch (FormatException ex)
                    {
                        // Log error 
                        throw new Exception($"Invalid keyword for Name: {keyword}", ex);
                        // Throw again or return empty result
                    }

                }
            return new List<Customer>();

        }
        



    }
}