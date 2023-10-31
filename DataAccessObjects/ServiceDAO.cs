using BusinessObjects;

namespace DataAccessObjects
{
    public class ServiceDAO
    {
        //use Singleton
        private static ServiceDAO instance = null;
        private static readonly object instanceLock = new object();

        private ServiceDAO() { }

        public static ServiceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ServiceDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Service> GetServices()
        {
            using (var context = new StudentHouseMembershipContext())
            {
                return context.Services.ToList();
            }
        }
        public Service GetServiceById(int id)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                return context.Services.Find(id);
            }
        }
        public void AddService(Service service)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                context.Services.Add(service);
                context.SaveChanges();
            }
        }
        public void UpdateService(Service service)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                var serviceToUpdate = context.Services.Find(service.ServiceId);
                {
                    serviceToUpdate.ServiceName = service.ServiceName;
                    serviceToUpdate.LatestUpdate = service.LatestUpdate;
                    serviceToUpdate.AmountOfTime = service.AmountOfTime;
                    serviceToUpdate.Price = service.Price;
                    serviceToUpdate.Status = service.Status;
                    serviceToUpdate.AdminId = service.AdminId;

                }
                context.SaveChanges();
            }
        }
        public void DeleteService(Service service)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                var serviceToDelete = context.Services.Find(service.ServiceId);
                context.Services.Remove(serviceToDelete);
                context.SaveChanges();
            }
        }
    }
}
