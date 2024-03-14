using QLBanDoAnNhanh.Models;
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
    public partial class frmlogin : Form
    {
        private PosFastFood _posFastFood;
        public bool Valid { get; set; } = false;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            picShow.Show();
            picHide.Hide();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbPass_Validating(object sender, CancelEventArgs e)
        {

        }

        private void picShow_Click(object sender, EventArgs e)
        {
            picShow.Hide();
            picHide.Show();
            tbPass.PasswordChar = '\0';
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            picShow.Show();
            picHide.Hide();
            tbPass.PasswordChar = '*';
        }
    }
}
