using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDoAnNhanh
{
    public partial class ItemOrder : UserControl
    {

        private int _id;
        private string _price;
        private string _name;
        private string _date;
        private int quantity;
        public ItemOrder()
        {
            InitializeComponent();
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; lbPrice.Text = value; }
        }

        public string _Name
        {
            get { return _name; }
            set { _name = value; lbName.Text = value; }
        }
        public string _Date
        {
            get { return _date; }
            set { _date = value; lbDate.Text = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; numQuantity.Value = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.Gray))
            {
                e.Graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1);
            }
        }
    }
}
