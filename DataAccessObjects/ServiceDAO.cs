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
                return context.Services.Where(p=> p.Active == true).ToList();
            }
        }
        public Service GetServiceById(int id)
        {
            using (var context = new StudentHouseMembershipContext())
            {
                return context.Services.SingleOrDefault(p=> p.ServiceId == id && p.Active == true);
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
                var serviceExist = context.Services.Find(service.ServiceId);
                //context.Services.Remove(serviceToDelete);
               if(serviceExist != null)
                {
                    serviceExist.Active = false;
                    context.SaveChanges();


                }
                    context.SaveChanges();

            }
        }
        public static bool ServicesIdExists(int staffId)
        {
            using (var context = new StudentHouseMembershipContext()) // Replace with your actual DbContext
            {
                return context.staff.Any(s => s.StaffId == staffId);
            }
        }
    }
}
