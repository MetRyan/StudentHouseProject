using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer) => CustomerDAO.Instance.AddCustomer(customer);

        public void inActiveCustomer(Customer customer) => CustomerDAO.Instance.inActiveCustomer(customer);
        public Customer GetCustomerById(int id) => CustomerDAO.Instance.GetCustomerById(id);

        public List<Customer> GetCustomers() => CustomerDAO.Instance.GetCustomers();

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);
        public Boolean CheckloginforCustomer(string email, string password) => CustomerDAO.CheckLoginforCustomer(email, password);

        public Customer getCustomerbyEmail(string email) => CustomerDAO.GetCustomerbyEmail(email);

        public List<Customer> SearchCustomerbyType(string keyword, string type) => CustomerDAO.SearchByType(keyword, type); 
    }

}
