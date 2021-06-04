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
using ChapeauUI;

namespace ChapeauUI
{
   

    public partial class ItemRow : UserControl
    {

        Item item;
        List<OrderItem> OrderItems { get; set; }
        AddOrderForm addOrderForm;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;



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
            //Item item = (Item)(sender as Button).Tag;
            //Order order = (Order)this.ParentForm.Tag;
            //addOrderForm = new AddOrderForm(item, order);
            var parent = this.Parent.Parent as OrderingUI;
             parent.SelectedItem = this.item;
            //addOrderForm.Show();
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);

            
            MessageBox.Show(item.Name);
        }

        
        
    }
}
