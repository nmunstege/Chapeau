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
    public partial class OrderItemRowTemp : UserControl
    {
        public OrderItem OrderItem { get; set; }
        
        public OrderItemRowTemp(OrderItem orderItem)
        {
            InitializeComponent();
            OrderItem = orderItem;
            FillLabels();
        }

        private void FillLabels()
        {
            lblCount.Text = OrderItem.Count.ToString() + "\u2715";
            lblItemName.Text = OrderItem.Item.Name;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as TempOrderItemsForm;

            if (OrderItem.Count > 1)
            {
                OrderItem.Count--;
                FillLabels();
            }
            else
            {
                parentForm.orderItems.Remove(OrderItem);
                parentForm.DrawOrderItems();
            }
            
        }
    }
}
