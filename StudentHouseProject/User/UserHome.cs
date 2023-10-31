using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;

namespace StudentHouseProject
{
    public partial class UserHome : Form
    {
        public Customer getCustomer {  get; set; }

        public UserHome()
        {
            InitializeComponent();
        }
    }
}
