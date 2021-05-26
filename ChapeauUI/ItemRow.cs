using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;
using System.Globalization;

namespace ChapeauUI
{
    public partial class ItemRow : UserControl
    {
        Item item;
        public ItemRow(Item item)
        {
            InitializeComponent();
            this.item = item;
            FillItems();
        }

        private void FillItems()
        {
            var culture = new CultureInfo("nl-NL");
            lblName.Text = item.Name;
            lblPrice.Text = item.Price.ToString("C", culture);
            btnAddItem.Tag = this.item;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder((Item)(sender as Button).Tag);
            addOrder.Show();
        }
    }
}
