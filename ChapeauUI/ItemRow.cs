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

        Item Item { get; set; }
        Order Order { get; set; }
        List<OrderItem> OrderItems { get; set; }
        AddOrderForm addOrderForm;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;



        public ItemRow(Item item, Order order)
        {
            InitializeComponent();
            Item = item;
            Order = order;
            FillItems();
        }

        private void FillItems()
        {
            var culture = new CultureInfo("nl-NL");
            lblName.Text = Item.Name;
            lblPrice.Text = Item.Price.ToString("C", culture);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var orderingUI = this.FindForm() as OrderingUI;
            orderingUI.SelectedItem = Item;
            addOrderForm = new AddOrderForm(Item, Order, orderingUI);

            addOrderForm.ShowDialog();

            string fuck = "";

            foreach (OrderItem o in orderingUI.TempOrderItems)

            {
                fuck += $"{o.Item.Name} x {o.Count} ({o.Comment}) \n";
            }

            MessageBox.Show(fuck);
        }



    }
}
