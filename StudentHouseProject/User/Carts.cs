using BusinessObjects;
using Repositories;
using StudentHouseProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using UI;

namespace StudentHouseProject.User
{
    public partial class Carts : Form
    {
        IOrderRepository repository = new OrderRepository();
        public   List<CartItems> listitems {  get; set; }
        public Customer getCustomer { get; set; }
        public Carts()
        {
            InitializeComponent();
        }
        private void populateItems()
        {
            List<CartItems> cartlist = repository.getCartsSession();
            CartsUser[] listitems = new CartsUser[20];
            //for (int i = 0; i < ServiceList.Count; i++)
            for (int i = 0; i < cartlist.Count(); i++)
            {


                listitems[i] = new CartsUser();
                listitems[i].icon = Resources._2;

                // listitems[i].icon = Resources.ResourceManager.GetObject($"_{1}") as Image;
                listitems[i].Title = "Title:  " + cartlist[i].ServiceName;
                listitems[i].Price = "Price:  " + cartlist[i].Price.ToString();
                //int serviceId = ServiceList[i].ServiceId;
                int serviceId = cartlist[i].ServiceId;


                listitems[i].RemoveCart += (item) =>
                {
                    // string serviceName = ServiceList.Find(service => service.ServiceId == serviceId)?.ServiceName;
                    /* UserViewServicesDetails f = new UserViewServicesDetails() { 
                    

                     }*/
                    // Lấy dữ liệu từ item được click
                    //  MessageBox.Show(serviceName);
                    bool cartRemove = repository.RemoveFromCartSession(serviceId);
                    if (cartRemove)
                    {
                        this.Hide(); // Hide the old MainMenu form
                        MessageBox.Show("Success");
                        MainMenu f = new MainMenu()
                        {
                            getCustomer = getCustomer,
                            listitems = listitems

                        };
                        f.button1_Click(null, null);

                        this.Hide(); // Hide the old MainMenu form
                        /*     UserHome userHome = new UserHome()

                             {
                                 getCustomer = getCustomerbyEmail,
                             };*/

                        // Trong class khác
                        f.Show();
                        f.Close();

                    }
                    else
                    {

                        MessageBox.Show("Fail");
                    }


                };
                txtTotal.Text = CalculateTotal().ToString();
                flowLayoutPanel1.Controls.Add(listitems[i]);
                //}



            }

        }
        private float CalculateTotal()
        {
            List<CartItems> cartlist = repository.getCartsSession();

            float total = 0.0f;
            if (cartlist.Count > 0)
            {
                foreach (var item in cartlist)
                {
                    total += item.Price;
                }
            }

            return total; // Return total as a float
        }

        private void Carts_Load(object sender, EventArgs e)
        {

            MessageBox.Show(getCustomer.Phone);

            if (getCustomer != null)
            {
                txtAdress.Text = getCustomer.Adress;
                txtPhone.Text = getCustomer.Phone;
            }
            else
            {

                MessageBox.Show("you have not login yet , please Login or Register");

            }
            populateItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {



            List<CartItems> cartlist = repository.getCartsSession();
            Order listOrder = new Order
            {
                CustomerId = getCustomer.CustomerId,
                Price = CalculateTotal(),
                Description = txtNote.Text,
                Status = "false",


            };
            int OrderId = repository.addOrder_getOrderId(listOrder);

            for (int i = 0; i < cartlist.Count(); i++)
            {

                OrderDetail listOrderDetail = new OrderDetail
                {
                    OrderId = OrderId,
                    Address = txtAdress.Text,
                    PaymentMethod = cbPayment.Text,
                    Pending = false,
                    Phone = txtPhone.Text,
                    Price = cartlist[i].Price,
                    ServiceId = cartlist[i].ServiceId,
                    ServiceName = cartlist[i].ServiceName,
                    CreateDate = DateTime.Now,
                    EndDate = null,
                };
                repository.AddOrder(listOrderDetail);
                MessageBox.Show("Order has been placed successfully.");
                cartlist.Clear();




            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
