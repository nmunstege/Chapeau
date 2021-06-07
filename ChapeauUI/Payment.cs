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
    public partial class Payment : Form
    {
        public Payment(Order order)
        {
            InitializeComponent();
            LoadPaymentHomeScreen(order);
        }

        void LoadPaymentHomeScreen(Order order)
        {
            OrderItemService orderItemService = new OrderItemService();
            ItemService itemService = new ItemService();
            pnlPaymentHomeScreen.Show();
            orderItemService.FillOrderWithOrderItems(order);
            itemService.FillOrderItemItems(order.OrderItems);

            foreach  (OrderItem orderItem in order.OrderItems)
            {
                ShowOrderItems(orderItem);       
            }         
        }

        void ShowOrderItems(OrderItem orderItem)
        {
            lvOrderItems.Items.Clear();
            foreach (Item item in orderItem.Items)
            {
                
                ListViewItem orderitem = new ListViewItem(item.Name);
                orderitem.SubItems.Add(orderItem.Count.ToString());
                orderitem.SubItems.Add(item.Price.ToString("€0.00"));
                double Total = item.Price * orderItem.Count;
                orderitem.SubItems.Add(Total.ToString("€0.00"));
                orderitem.Tag = orderitem;
                lvOrderItems.Items.Add(orderitem);

                //                Item indivalItem = itemService.GetItemByItemNr(orderItem);
                // individualItems.Add(indivalItem);

            }
            //return individualItems;
        }
    }
}
