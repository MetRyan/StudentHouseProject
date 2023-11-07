using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHouseProject.AdminAPage
{
    public partial class AdminServiceDetail : Form
    {
        public bool InserorUpdate { get; set; }
        public Service getService { get; set; }
        public AdminServiceDetail()
        {
            InitializeComponent();
        }
        IServiceRepository repository = new ServiceRepository();


        private void ServiceDetails_Load()
        {


            if (InserorUpdate)
            {
                txtServiceId.Enabled = false;

                //  Service getService = repository.(getStaffId);
                txtAmountOfTime.DataBindings.Add("Text", getService, "AmountOfTime");
                txtServiceId.DataBindings.Add("Text", getService, "ServiceId");
                txtServiceName.DataBindings.Add("Text", getService, "ServiceName");
                txtServicePrice.DataBindings.Add("Text", getService, "Price");
                cbStatus.DataBindings.Add("Text", getService, "Status");

                // validatoin -> khi input bi loi khong hien new input
                txtAmountOfTime.CausesValidation = false;
                txtServiceId.CausesValidation = false;
                txtServiceName.CausesValidation = false;
                txtServicePrice.CausesValidation = false;
                cbStatus.CausesValidation = false;



                //   txtAdress.CausesValidation = false;

                /*           txtCarName.DataBindings.Add("Text", car, "CarName", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarDescription.DataBindings.Add("Text", car, "CarDescription", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtNumberOfDoor.DataBindings.Add("Text", car, "NumberOfDoors", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtSeatingCapacity.DataBindings.Add("Text", car, "SeatingCapacity", false, DataSourceUpdateMode.OnPropertyChanged);
                           cbFuelType.DataBindings.Add("Text", car, "FuelType", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtManufacturer.DataBindings.Add("Text", car, "ManufacturerId", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtSupplierID.DataBindings.Add("Text", car, "SupplierId", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarStatus.DataBindings.Add("Text", car, "CarStatus", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtCarRenting.DataBindings.Add("Text", car, "CarRentingPricePerDay", false, DataSourceUpdateMode.OnPropertyChanged);
                           txtYear.DataBindings.Add("Text", car, "Year", false, DataSourceUpdateMode.OnPropertyChanged); ;*/

            }
        }


        // Get a list of existing staff IDs

        // Generate a new unique StaffId


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (
                    txtAmountOfTime.Text == ""
                    || txtServiceId.Text == ""
                    || txtServiceName.Text == ""
                    || cbStatus.Text == ""
                    || txtServicePrice.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Service Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int ServiceId = int.Parse(txtServiceId.Text);
                    int Price = int.Parse(txtServicePrice.Text);
                    int Time = int.Parse(txtAmountOfTime.Text);

                    if (InserorUpdate == false)
                    {
                        bool ServiceIdExists = repository.ServicesIdExist(ServiceId);
                        if (ServiceIdExists)
                        {
                            MessageBox.Show("Services with the same ID already exists in the database.", "Services Management",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (!int.TryParse(txtServiceId.Text, out ServiceId))
                    {
                        MessageBox.Show("ServiceId must be a valid integer.", "Service Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ServiceId < 1)
                    {
                        MessageBox.Show("StaffId must be a positive integer.", "Service Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (!int.TryParse(txtServicePrice.Text, out Price))
                    {
                        MessageBox.Show("Price must be valid Integer", "Service Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Price < 1)
                    {
                        MessageBox.Show("Price must be positive Integer", "Service Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!int.TryParse(txtAmountOfTime.Text, out Time))
                    {
                        MessageBox.Show("Time must be integer", "Service Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Price < 1)
                    {
                        MessageBox.Show("Time must be positive Integer", "Service Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {


                        Service p = new Service
                        {
                            AmountOfTime = Time,
                            LatestUpdate = DateTime.Now,
                            Price = Price,
                            ServiceId = ServiceId,
                            Status = cbStatus.Text,
                            ServiceName = txtServiceName.Text,
                            //Set default admin la 1 -> vi chi co 1 admin neu nhieu hon thi lam lai
                            AdminId = 1,

                           Active = true,


                        };



                        if (InserorUpdate == false)
                        {


                            repository.AddService(p);
                            MessageBox.Show("Success", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Close();
                        }
                        else
                        {
                            p.ServiceId = getService.ServiceId;

                            repository.UpdateService(p);
                            MessageBox.Show("Success", "Services Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Close();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"An error oddddccurred: {ex.Message}", "Error",
//            MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtServiceId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminServiceDetail_Load(object sender, EventArgs e)
        {
            ServiceDetails_Load();
        }
    }
}
