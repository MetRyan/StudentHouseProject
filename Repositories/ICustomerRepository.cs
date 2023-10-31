using BusinessObjects;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);



    }
}
