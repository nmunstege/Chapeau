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
using ChapeauUI;

namespace ChapeauUI
{
    public partial class AddOrderForm : Form
    {
        public Item Item { get; set; }
        public int Count { get; set; }
        public string Comment { get; set; }
        public bool HasComment { get { return Comment != ""; } }
        public Order Order { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        OrderingUI orderingUI;

        public AddOrderForm(Item item, Order order, OrderingUI orderingUI)
        {
            Item = item;
            Order = order;
            Count = 1;
            InitializeComponent();
            FillLabels(Item);
            Location = new Point(100, 90);
            Comment = "";
            this.orderingUI = orderingUI;
        }

        private void FillLabels(Item item)
        {
            lblAddItemHeader.Text = $"Add  {item.Name} to the Order {Order.UserId}";
            lblMessage.Text = $"Do you want to add {this.Count} {item.Name}?";
            txtBoxQuantity.Text = Count.ToString();
        }

        private void btnCancelAddOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            Count++;
            FillLabels(this.Item);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Comment = textBox2.Text;

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            orderingUI.TempOrderItems.Add(new OrderItem(Item, Order, Count, Comment));
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
