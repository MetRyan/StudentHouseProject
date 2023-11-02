using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHouseProject.User
{
    public partial class ListItems : UserControl
    {
        public ListItems()
        {
            InitializeComponent();
        }


        #region Properties
        private string _title;
        private string _price;
        private string _time;
        private Image _image;

        public delegate void AddToCartHandler(ListItems item);
        public event AddToCartHandler OnAddToCart;

        public void AddtoCart_Click(object sender, EventArgs e)
        {
            OnAddToCart?.Invoke(this);

        }

        [Category("display")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }

        }
        [Category("display")]

        public string Price
        {
            get { return _price; }
            set { _price = value; lbPrice.Text = value; }

        }
        [Category("display")]

        public string Time
        {
            get { return _time; }
            set { _time = value; lbTime.Text = value; }

        }
        [Category("display")]

        public Image icon
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }

        }
        #endregion

    }
}
