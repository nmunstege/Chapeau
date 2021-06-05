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

namespace ChapeauUI
{
    public partial class TempOrderItemsForm : Form
    {
        public List<OrderItem> orderItems;
        OrderingUI orderingUI;
        public TempOrderItemsForm(OrderingUI orderingUI)
        {
            orderItems = orderingUI.TempOrderItems;
            this.orderingUI = orderingUI;
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
            OrderItemService orderItemService = new OrderItemService();
            orderItemService.AddOrderItem(this.orderItems);
            orderingUI.TempOrderItems.Clear();
            this.Close();
        }
    }
}
