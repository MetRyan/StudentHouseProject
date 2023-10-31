using BusinessObjects;

namespace Repositories.Interface
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);
        public Boolean CheckloginforCustomer(String email, string password);
        public Customer getCustomerbyEmail (String email);



    }
}
