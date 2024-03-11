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
        private Item _itemProduct;
        private ItemOrder _itemOrder;
        private decimal _price = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //flpOrder.Controls.Clear();
            btnFoods.PerformClick();
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
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productFoods = _posFastFood.Products.Where(x => x.IdTypeProduct == 1).ToList();
            foreach (var item in productFoods)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = item.PriceProduct.Value.ToString("0.0") + "$";
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
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productFoods = _posFastFood.Products.Where(x => x.IdTypeProduct == 2).ToList();
            foreach (var item in productFoods)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = item.PriceProduct.Value.ToString("0.0") + "$";
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
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productFoods = _posFastFood.Products.Where(x => x.IdTypeProduct == 3).ToList();
            foreach (var item in productFoods)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = item.PriceProduct.Value.ToString("0.0") + "$";
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
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productFoods = _posFastFood.Products.Where(x => x.IdTypeProduct == 4).ToList();
            foreach (var item in productFoods)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = item.PriceProduct.Value.ToString("0.0") + "$";
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
            flpItems.Controls.Clear();
            _posFastFood = new PosFastFood();
            var productFoods = _posFastFood.Products.Where(x => x.IdTypeProduct == 5).ToList();
            foreach (var item in productFoods)
            {
                _itemProduct = new Item();
                _itemProduct.ID = item.IdProduct;
                _itemProduct._Name = item.NameProduct;
                _itemProduct.Price = item.PriceProduct.Value.ToString("0.0") + "$";
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
            Form form = new frmAddItem();
            form.ShowDialog();
            btnFoods.PerformClick();
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
                _itemOrder.Tag = itemControl.ID;
                _itemOrder.upDown.ValueChanged += numQuantity_Valuechanged;
                flpOrder.Controls.Add(_itemOrder);
                foreach (Control control in flpOrder.Controls)
                {
                    if (control is ItemOrder itemOrder)
                    {
                        _price += (decimal.Parse(itemOrder.Price.Substring(0, itemOrder.Price.Length - 1)) * itemOrder.Quantity);
                    }
                }
            }
            else
            {
                itemControl.IsValid = false;
                _price = 0;
                foreach (Control control in flpOrder.Controls)
                {
                    if (control is ItemOrder itemOrder)
                    {
                        _price += (decimal.Parse(itemOrder.Price.Substring(0, itemOrder.Price.Length - 1)) + itemOrder.Quantity);
                    }
                }
                foreach (Control control in flpOrder.Controls)
                {
                    if (control is ItemOrder itemOrder)
                    {
                        if ((int)itemOrder.Tag == (int)itemControl.Tag)
                        {
                            _price -= (decimal.Parse(itemOrder.Price.Substring(0, itemOrder.Price.Length - 1)) * itemOrder.Quantity);
                            flpOrder.Controls.Remove(itemOrder);
                        }
                    }
                }
            }
            lbTotal.Text = _price.ToString("0.0") + "$";
            lbLastPrice.Text = _price.ToString("0.0") + "$";
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
                    _price += (decimal.Parse(itemOrder.Price.Substring(0, itemOrder.Price.Length - 1)) * itemOrder.Quantity);
                }
            }
            lbTotal.Text = _price.ToString("0.0") + "$";
            lbLastPrice.Text = _price.ToString("0.0") + "$";
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
    }
}
