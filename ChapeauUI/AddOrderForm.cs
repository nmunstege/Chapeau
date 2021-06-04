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
        public Order CurrentOrder { get; set; }
        public event EventHandler ButtonClick;
        public List<OrderItem> OrderItems { get; set; }
        
        public AddOrderForm(Item item, Order order)
        {
            Item = item;
            CurrentOrder = order;
            Count = 1;
            InitializeComponent();
            FillLabels(Item);
            Location = new Point(100, 90);
            Comment = "";
        }

        private void FillLabels(Item item)
        {
            lblAddItemHeader.Text = $"Add  {this.Item.Name} to the Order {CurrentOrder.UserId}" ; 
            lblMessage.Text = $"Do you want to add {this.Count} {this.Item.Name}?";
            txtBoxQuantity.Text = Count.ToString();
        }

        

        private void btnCancelAddOrder_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            Count++;
            FillLabels(this.Item );
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Comment = textBox2.Text;
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if(this.ButtonClick!= null)
            {
                this.ButtonClick(this, e);
            }
            //OrderItems = orderItemService.AddOrderItemtoTemp(CurrentOrder, Item, Count, Comment);
            
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
