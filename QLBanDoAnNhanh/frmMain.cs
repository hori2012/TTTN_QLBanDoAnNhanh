using QLBanDoAnNhanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDoAnNhanh
{
    public partial class frmMain : Form
    {
        private PosFastFood _posFastFood;
        private int _idEmployee;
        private Item _itemProduct;
        private ItemOrder _itemOrder;
        private decimal _price = 0;
        private int _category;

        private frmlogin _frmlogin = new frmlogin();
        public frmMain(int idEmployee, frmlogin frmlogin)
        {
            InitializeComponent();
            _idEmployee = idEmployee;
            _frmlogin = frmlogin;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //flpOrder.Controls.Clear();
            btnFoods.PerformClick();
            var emp = _posFastFood.Employees.Find(_idEmployee);
            lbUser.Text = emp.NameEmployee;
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.FromArgb(249, 130, 68);
            btnFoods.FillColor2 = Color.FromArgb(247, 72, 115);
            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;
            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;
            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;
            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;
            btnAdditem.FillColor = Color.Transparent;
            btnAdditem.FillColor2 = Color.Transparent;
            lbCategory.Text = "Foods";
            _category = 1;
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productItems = _posFastFood.Products.Where(x => x.IdTypeProduct == 11).ToList();
            foreach (var item in productItems)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = (decimal)item.PriceProduct;
                _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.0") + "$";
                if (item.IsActive == true)
                {
                    _itemProduct.IsActive = false;
                }
                else
                {
                    _itemProduct.IsActive = true;
                }
                using (MemoryStream ms = new MemoryStream(item.Images))
                {
                    Image image = Image.FromStream(ms);
                    _itemProduct.BackgroundImage = image;
                }
                _itemProduct.Tag = item.IdProduct;
                _itemProduct.Click += new System.EventHandler(this.Item_Click);
                _itemProduct.MouseDown += Item_RightClick;
                flpItems.Controls.Add(_itemProduct);
                CheckItemInOrder();
            }
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;
            btnDrink.FillColor = Color.FromArgb(249, 130, 68);
            btnDrink.FillColor2 = Color.FromArgb(247, 72, 115);
            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;
            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;
            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;
            btnAdditem.FillColor = Color.Transparent;
            btnAdditem.FillColor2 = Color.Transparent;
            lbCategory.Text = "Drink";
            _category = 2;
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productItems = _posFastFood.Products.Where(x => x.IdTypeProduct == 12).ToList();
            foreach (var item in productItems)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = (decimal)item.PriceProduct;
                _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.0") + "$";
                if (item.IsActive == true)
                {
                    _itemProduct.IsActive = false;
                }
                else
                {
                    _itemProduct.IsActive = true;
                }
                using (MemoryStream ms = new MemoryStream(item.Images))
                {
                    Image image = Image.FromStream(ms);
                    _itemProduct.BackgroundImage = image;
                }
                _itemProduct.Tag = item.IdProduct;
                _itemProduct.Click += new System.EventHandler(this.Item_Click);
                _itemProduct.MouseDown += Item_RightClick;
                flpItems.Controls.Add(_itemProduct);
            }
            CheckItemInOrder();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;
            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;
            btnSnack.FillColor = Color.FromArgb(249, 130, 68);
            btnSnack.FillColor2 = Color.FromArgb(247, 72, 115);
            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;
            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;
            btnAdditem.FillColor = Color.Transparent;
            btnAdditem.FillColor2 = Color.Transparent;
            lbCategory.Text = "Snack";
            _category = 3;
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productItems = _posFastFood.Products.Where(x => x.IdTypeProduct == 13).ToList();
            foreach (var item in productItems)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = (decimal)item.PriceProduct;
                _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.0") + "$";
                if (item.IsActive == true)
                {
                    _itemProduct.IsActive = false;
                }
                else
                {
                    _itemProduct.IsActive = true;
                }
                using (MemoryStream ms = new MemoryStream(item.Images))
                {
                    Image image = Image.FromStream(ms);
                    _itemProduct.BackgroundImage = image;
                }
                _itemProduct.Tag = item.IdProduct;
                _itemProduct.Click += new System.EventHandler(this.Item_Click);
                _itemProduct.MouseDown += Item_RightClick;
                flpItems.Controls.Add(_itemProduct);
                CheckItemInOrder();
            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;
            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;
            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;
            btnDessert.FillColor = Color.FromArgb(249, 130, 68);
            btnDessert.FillColor2 = Color.FromArgb(247, 72, 115);
            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;
            btnAdditem.FillColor = Color.Transparent;
            btnAdditem.FillColor2 = Color.Transparent;
            lbCategory.Text = "Dessert";
            _category = 4;
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productItems = _posFastFood.Products.Where(x => x.IdTypeProduct == 14).ToList();
            foreach (var item in productItems)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = (decimal)item.PriceProduct;
                _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.0") + "$";
                if (item.IsActive == true)
                {
                    _itemProduct.IsActive = false;
                }
                else
                {
                    _itemProduct.IsActive = true;
                }
                using (MemoryStream ms = new MemoryStream(item.Images))
                {
                    Image image = Image.FromStream(ms);
                    _itemProduct.BackgroundImage = image;
                }
                _itemProduct.Tag = item.IdProduct;
                _itemProduct.Click += new System.EventHandler(this.Item_Click);
                _itemProduct.MouseDown += Item_RightClick;
                flpItems.Controls.Add(_itemProduct);
                CheckItemInOrder();
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;
            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;
            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;
            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;
            btnCombo.FillColor = Color.FromArgb(249, 130, 68);
            btnCombo.FillColor2 = Color.FromArgb(247, 72, 115);
            btnAdditem.FillColor = Color.Transparent;
            btnAdditem.FillColor2 = Color.Transparent;
            lbCategory.Text = "Combo";
            _category = 5;
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productItems = _posFastFood.Products.Where(x => x.IdTypeProduct == 15).ToList();
            foreach (var item in productItems)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = (decimal)item.PriceProduct;
                _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.0") + "$";
                if (item.IsActive == true)
                {
                    _itemProduct.IsActive = false;
                }
                else
                {
                    _itemProduct.IsActive = true;
                }
                using (MemoryStream ms = new MemoryStream(item.Images))
                {
                    Image image = Image.FromStream(ms);
                    _itemProduct.BackgroundImage = image;
                }
                _itemProduct.Tag = item.IdProduct;
                _itemProduct.Click += new System.EventHandler(this.Item_Click);
                _itemProduct.MouseDown += Item_RightClick;
                flpItems.Controls.Add(_itemProduct);
                CheckItemInOrder();
            }
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            btnFoods.FillColor = Color.Transparent;
            btnFoods.FillColor2 = Color.Transparent;
            btnDrink.FillColor = Color.Transparent;
            btnDrink.FillColor2 = Color.Transparent;
            btnSnack.FillColor = Color.Transparent;
            btnSnack.FillColor2 = Color.Transparent;
            btnDessert.FillColor = Color.Transparent;
            btnDessert.FillColor2 = Color.Transparent;
            btnCombo.FillColor = Color.Transparent;
            btnCombo.FillColor2 = Color.Transparent;
            btnAdditem.FillColor = Color.FromArgb(249, 130, 68);
            btnAdditem.FillColor2 = Color.FromArgb(247, 72, 115);
            _posFastFood = new PosFastFood();
            var employee = _posFastFood.Employees.Find(_idEmployee);
            if (employee.IdRole == 1 || string.Compare(employee.RoleEmployee.NameRole, "admin", false) == 0)
            {
                Form form = new frmAddItem(_idEmployee);
                form.ShowDialog();
                btnFoods.PerformClick();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Please log in as a management account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Item itemControl = (Item)sender;
            if (itemControl.IsValid == false && itemControl.IsActive == false)
            {
                _price = 0;
                itemControl.IsValid = true;
                _itemOrder = new ItemOrder();
                _itemOrder.ID = itemControl.ID;
                _itemOrder._Name = itemControl._Name;
                _itemOrder.Price = itemControl.Price;
                _itemOrder._Date = DateTime.Now.ToString();
                _itemOrder.Quantity = 1;
                _itemOrder.Image = _itemProduct.BackgroundImage;
                _itemOrder.LablePrice = itemControl.Price.ToString("0.0") + "$";
                _itemOrder.Tag = itemControl.ID;
                _itemOrder.upDown.ValueChanged += numQuantity_Valuechanged;
                flpOrder.Controls.Add(_itemOrder);
                foreach (Control control in flpOrder.Controls)
                {
                    if (control is ItemOrder itemOrder)
                    {
                        _price += (itemOrder.Price * itemOrder.Quantity);
                    }
                }
            }
            else
            {
                itemControl.IsValid = false;
                foreach (Control control in flpOrder.Controls)
                {
                    if (control is ItemOrder itemOrder)
                    {
                        if ((int)itemOrder.Tag == (int)itemControl.Tag)
                        {
                            _price -= (itemOrder.Price * itemOrder.Quantity);
                            flpOrder.Controls.Remove(itemOrder);
                        }
                    }
                }
            }
            lbVAT.Text = "-" + ((decimal)0.5 * _price).ToString("0.0") + "$";
            lbTotal.Text = _price.ToString("0.0") + "$";
            lbLastPrice.Text = (_price + ((decimal)0.5 * _price)).ToString("0.0") + "$";
        }
        private void numQuantity_Valuechanged(object sender, EventArgs e)
        {
            NumericUpDown upDown = sender as NumericUpDown;
            _price = 0;
            foreach (Control control in flpOrder.Controls)
            {
                if (control is ItemOrder itemOrder)
                {
                    if ((int)itemOrder.Tag == (int)upDown.Parent.Tag)
                    {
                        itemOrder.Quantity = (int)upDown.Value;
                    }
                    _price += (itemOrder.Price * itemOrder.Quantity);
                    itemOrder.LablePrice = (itemOrder.Price * itemOrder.Quantity).ToString("0.0") + "$";

                }
            }
            lbVAT.Text = "-" + ((decimal)0.5 * _price).ToString("0.0") + "$";
            lbTotal.Text = _price.ToString("0.0") + "$";
            lbLastPrice.Text = (_price+ ((decimal)0.5 * _price)).ToString("0.0") + "$";
        }
        private void CheckItemInOrder()
        {
            foreach (Control controlItem in flpItems.Controls)
            {
                if (controlItem is Item item)
                {
                    foreach (Control controlItemOrder in flpOrder.Controls)
                    {
                        if (controlItemOrder is ItemOrder itemOrder)
                        {
                            if ((int)item.Tag == (int)itemOrder.Tag)
                            {
                                item.IsValid = true;
                            }
                        }
                    }
                }
            }
        }
        private void Item_RightClick(object sender, MouseEventArgs e)
        {
            Item itemProduct = (Item)sender;
            if (e.Button == MouseButtons.Right)
            {
                Form form = new frmItemDetail((int)itemProduct.ID, _idEmployee);
                form.ShowDialog();
                switch (_category)
                {
                    case 1:
                        btnFoods.PerformClick(); break;
                    case 2:
                        btnDrink.PerformClick(); break;
                    case 3:
                        btnSnack.PerformClick(); break;
                    case 4:
                        btnDessert.PerformClick(); break;
                    case 5:
                        btnCombo.PerformClick(); break;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _posFastFood = new PosFastFood();
                var productItem = _posFastFood.Products.Where(x=>x.IdTypeProduct == _category && x.NameProduct.ToLower().Equals(txtSearch.Text.ToLower())).ToList();
                if (productItem.Count > 0)
                {
                    flpItems.Controls.Clear();
                    foreach (var item in productItem)
                    {
                        _itemProduct = new Item();
                        _itemProduct.ID = item.IdProduct;
                        _itemProduct._Name = item.NameProduct;
                        _itemProduct.Price = (decimal)item.PriceProduct;
                        _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.0") + "$";
                        if (item.IsActive == true)
                        {
                            _itemProduct.IsActive = false;
                        }
                        else
                        {
                            _itemProduct.IsActive = true;
                        }
                        using (MemoryStream ms = new MemoryStream(item.Images))
                        {
                            Image image = Image.FromStream(ms);
                            _itemProduct.BackgroundImage = image;
                        }
                        _itemProduct.Tag = item.IdProduct;
                        _itemProduct.Click += new System.EventHandler(this.Item_Click);
                        _itemProduct.MouseDown += Item_RightClick;
                        flpItems.Controls.Add(_itemProduct);
                        CheckItemInOrder();
                    }
                }
                else
                {
                    switch (_category)
                    {
                        case 1:
                            btnFoods.PerformClick(); break;
                        case 2:
                            btnDrink.PerformClick(); break;
                        case 3:
                            btnSnack.PerformClick(); break;
                        case 4:
                            btnDessert.PerformClick(); break;
                        case 5:
                            btnCombo.PerformClick(); break;
                    }
                    DialogResult dialog = MessageBox.Show("Can't find this item!");
                }
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            _posFastFood = new PosFastFood();
            var productItem = _posFastFood.Products.Where(x => x.IdTypeProduct == _category && x.NameProduct.ToLower().Equals(txtSearch.Text.ToLower())).ToList();
            if (productItem.Count > 0)
            {
                flpItems.Controls.Clear();
                foreach (var item in productItem)
                {
                    _itemProduct = new Item();
                    _itemProduct.ID = item.IdProduct;
                    _itemProduct._Name = item.NameProduct;
                    _itemProduct.Price = (decimal)item.PriceProduct;
                    _itemProduct.LablePrice = item.PriceProduct.Value.ToString("0.0") + "$";
                    if (item.IsActive == true)
                    {
                        _itemProduct.IsActive = false;
                    }
                    else
                    {
                        _itemProduct.IsActive = true;
                    }
                    using (MemoryStream ms = new MemoryStream(item.Images))
                    {
                        Image image = Image.FromStream(ms);
                        _itemProduct.BackgroundImage = image;
                    }
                    _itemProduct.Tag = item.IdProduct;
                    _itemProduct.Click += new System.EventHandler(this.Item_Click);
                    _itemProduct.MouseDown += Item_RightClick;
                    flpItems.Controls.Add(_itemProduct);
                    CheckItemInOrder();
                }
            }
            else
            {
                switch (_category)
                {
                    case 1:
                        btnFoods.PerformClick(); break;
                    case 2:
                        btnDrink.PerformClick(); break;
                    case 3:
                        btnSnack.PerformClick(); break;
                    case 4:
                        btnDessert.PerformClick(); break;
                    case 5:
                        btnCombo.PerformClick(); break;
                }
                DialogResult dialog = MessageBox.Show("Can't find this item!");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            _frmlogin.Show();
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2ControlBox1.PerformClick();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form frmchangePass = new frmChangePass(_idEmployee);
            frmchangePass.ShowDialog();
        }
    }
}
