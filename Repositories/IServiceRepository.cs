using BusinessObjects;

namespace Repositories
{
    public interface IServiceRepository
    {
        public List<Service> GetServices();
        public Service GetServiceById(int id);
        public void AddService(Service service);
        public void UpdateService(Service service);
        public void DeleteService(Service service);
        public bool ServicesIdExist(int id);
    }
}
