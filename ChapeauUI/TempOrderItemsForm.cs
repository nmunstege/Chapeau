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
    public partial class TempOrderItemsForm : Form
    {
        public List<OrderItem> orderItems;
        public TempOrderItemsForm(OrderingUI orderingUI)
        {
            orderItems = orderingUI.TempOrderItems;
            InitializeComponent();
            DrawOrderItems();
        }

        //
        // Nazirou
        // Draw List Flow with temp Order items
        public void DrawOrderItems()
        {
            orderItemFlowLayoutPanel.Controls.Clear();

            foreach (OrderItem orderItem in this.orderItems)
            {
                OrderItemRowTemp orderItemRow = new OrderItemRowTemp(orderItem);
                orderItemFlowLayoutPanel.Controls.Add(orderItemRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
