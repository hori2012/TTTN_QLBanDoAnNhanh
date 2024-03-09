using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDoAnNhanh
{
    public partial class Item : UserControl
    {
        private int _id;
        private string _price;
        private string _name;
        private bool _isActive;
        public Item()
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
            set { _price = value; lbPrice.Text = value;  }
        }

        public string _Name
        {
            get { return _name; }
            set { _name = value; lbName.Text = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; pnSoldout.Visible = value; }
        }
        public bool IsValid()
        {
            if (btnValid.Visible == false)
            {
                btnValid.Visible = true;
            }
            else
            {
                btnValid.Visible = false;
            }
            return btnValid.Visible;
        }

    }
}
