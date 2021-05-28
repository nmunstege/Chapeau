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

namespace ChapeauUI
{
    public partial class AddOrderForm : Form
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
        public bool HasComment { get { return Comment != ""; } }
        public AddOrderForm(Item item)
        {
            Item = item;
            Quantity = 1;
            InitializeComponent();
            FillLabels(Item);
            Location = new Point(100, 90);

        }

        private void FillLabels(Item item)
        {
            lblAddItemHeader.Text = $"Add  {this.Item.Name} to the Order" ; 
            lblMessage.Text = $"Do you want to add {this.Quantity} {this.Item.Name}?";
            txtBoxQuantity.Text = Quantity.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fuck_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAddOrder_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            Quantity++;
            FillLabels(this.Item );
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Comment = textBox2.Text;
        }
    }
}
