using BusinessObjects;
using Repositories;
using StudentHouseProject.Properties;
using StudentHouseProject.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StudentHouseProject
{
    public partial class UserHome : Form
    {
        public Customer getCustomer { get; set; }
        IServiceRepository repositorty = new ServiceRepository();

        public UserHome()
        {
            InitializeComponent();
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            populateItems();

        }
        IOrderRepository repository_Order = new OrderRepository();
        IServiceRepository repository_Service = new ServiceRepository();

        private void populateItems()
        {
            List<Service> ServiceList = repositorty.GetServices();
            ListItems[] listitems = new ListItems[20];

            //for (int i = 0; i < ServiceList.Count; i++)
            for (int i = 0; i < ServiceList.Count(); i++)
            {


                listitems[i] = new ListItems();
                listitems[i].icon = Resources._2;

                // listitems[i].icon = Resources.ResourceManager.GetObject($"_{1}") as Image;
                listitems[i].Title = "Title:  " + ServiceList[i].ServiceName;
                listitems[i].Price = "Price:  " + ServiceList[i].Price.ToString();
                listitems[i].Time = "Time:   " + ServiceList[i].AmountOfTime.ToString();
                //int serviceId = ServiceList[i].ServiceId;
                int serviceId = ServiceList[i].ServiceId;


                listitems[i].OnAddToCart += (item) =>
                {
                    Service serviceObject = repository_Service.GetServiceById(serviceId);
                    Boolean addItems = repository_Order.AddToCartSession(serviceObject);
                    if (addItems)
                    {
                        MessageBox.Show("success");


                    }
                    else {

                        MessageBox.Show("AlredyInYourCart");
                    
                    }
                   // string serviceName = ServiceList.Find(service => service.ServiceId == serviceId)?.ServiceName;
                    /* UserViewServicesDetails f = new UserViewServicesDetails() { 


                     }*/
                    // Lấy dữ liệu từ item được click
                    //  MessageBox.Show(serviceName);

                };

                flowLayoutPanel1.Controls.Add(listitems[i]);
                //}



            }

        }


    }
}
