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
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            if(btnValid.Visible == false)
            {
                btnValid.Visible = true;
            }
            else
            {
                btnValid.Visible = false;
            }
        }

        private void pnName_Click(object sender, EventArgs e)
        {

            if (btnValid.Visible == false)
            {
                btnValid.Visible = true;
            }
            else
            {
                btnValid.Visible = false;
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            if (btnValid.Visible == false)
            {
                btnValid.Visible = true;
            }
            else
            {
                btnValid.Visible = false;
            }
        }
    }
}
