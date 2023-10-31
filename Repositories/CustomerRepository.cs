using BusinessObjects;
using DataAccessObjects;
using Repositories.Interface;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer) => CustomerDAO.Instance.AddCustomer(customer);

        public void DeleteCustomer(Customer customer) => CustomerDAO.Instance.DeleteCustomer(customer);
        public Customer GetCustomerById(int id) => CustomerDAO.Instance.GetCustomerById(id);

        public List<Customer> GetCustomers() => CustomerDAO.Instance.GetCustomers();

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);
        public Boolean CheckloginforCustomer(string email, string password) => CustomerDAO.CheckLoginforCustomer(email, password);

        public Customer getCustomerbyEmail(string email) => CustomerDAO.GetCustomerbyEmail(email);
    }

}
