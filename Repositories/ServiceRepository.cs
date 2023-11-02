using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public void AddService(Service service) => ServiceDAO.Instance.AddService(service);

        public void DeleteService(Service service) => ServiceDAO.Instance.DeleteService(service);

        public Service GetServiceById(int id) => ServiceDAO.Instance.GetServiceById(id);

        public List<Service> GetServices() => ServiceDAO.Instance.GetServices();

        public bool ServicesIdExist(int id) => ServiceDAO.ServicesIdExists(id);

        public void UpdateService(Service service) => ServiceDAO.Instance.UpdateService(service);
    }
}
