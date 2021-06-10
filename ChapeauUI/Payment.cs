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
        OrderService orderService;
        BillService billService;
        public Payment(Order order)
        {
            
            InitializeComponent();
            LoadPaymentHomeScreen(order);
            
        }

        void LoadPaymentHomeScreen(Order order)
        {
            orderService = new OrderService();
            //show labels on the homescreen
            pnlPaymentHomeScreen.Show();
            
            pnlPaymentOptions.Hide();
            lblUserId.Text = order.UserId.ToString();
            lblTableNumber.Text = order.TableId.ToString();
            lblOrderId.Text = order.Id.ToString();

            OrderItemService orderItemService = new OrderItemService();
            ItemService itemService = new ItemService();
            //fill list in order with orderitems 
            orderItemService.FillOrderWithOrderItems(order);
            //fill list in orderitems with items
            itemService.FillOrderItemItems(order.OrderItems);

            //Show order items
            foreach (OrderItem orderItem in order.OrderItems)
            {
                ShowOrderItems(orderItem);
            }
            //show vat
            double totalVAT= TotalVAT(order);
           double amountPayable= orderService.CalculateAmountPayable(totalVAT,order);
            lblTotalBeforeTip.Text = amountPayable.ToString("0.00");
            txtTotalPrice.Text = amountPayable.ToString("0.00");
            double tip = CalculateTip();
            pnlCalculator.Hide();
        }

        void ShowOrderItems(List<OrderItem>orderItems)
        {
            lvOrderItems.Items.Clear();
            foreach (OrderItem orderItem in orderItems)
            {
                ListViewItem orderitem = new ListViewItem(orderItem.item.Name);
                orderitem.SubItems.Add(orderItem.Count.ToString());
                orderitem.SubItems.Add(orderItem.item.Price.ToString("€0.00"));
                double Total = orderItem.Price * orderItem.Count;
                orderitem.SubItems.Add(Total.ToString("€0.00"));
                orderitem.Tag = orderitem;
                lvOrderItems.Items.Add(orderitem);
            }
        }

        double TotalVAT(Order order)
        {
            double vatHigh = 0;
            double vatLow = 0;
             
            foreach (OrderItem orderitem in order.OrderItems)
            {
                foreach (Item item in orderitem.Items)
                {
                    if (item.Id == orderitem.ItemId)
                    {
                        double vatCalc = orderService.CalculateVat(orderitem, item);
                        double lowVatCategory = orderService.LowVATCategory(item);
                        if (item.VAT == lowVatCategory)
                        {
                            vatLow += vatCalc;
                        }
                        else
                        {
                            vatHigh += vatCalc;
                        }
                        break;
                    }
                }
            }
            lblHighVat.Text = vatHigh.ToString("0.00");
            lblLowVat.Text = vatLow.ToString("0.00");
            return vatHigh + vatLow; 
        }

        double CalculateTip()
        {
            double tip = 0;
            if (txtTip.Text != "")
            {
                tip = double.Parse(txtTip.Text.ToString());
            }
            else if (double.Parse(txtTotalPrice.Text.ToString()) > double.Parse(lblTotalBeforeTip.Text.ToString()))
            {
                tip += double.Parse(txtTotalPrice.Text.ToString()) - double.Parse(txtTotalPrice.Text.ToString());
            }


            return tip;
        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
             pnlCalculator.Show();
            btnEnterTotalPrice.Enabled = false;
            btnCalEnter.Enabled = true;
            btnCalEnter.BringToFront();
            CheckTotalPrice();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            pnlCalculator.Show();
            btnEnterTotalPrice.Enabled = true;
            btnEnterTotalPrice.BringToFront();
            btnCalEnter.Enabled = false;
            txtResult.Text = txtTotalPrice.Text;
            CheckTotalPrice();
        }

        // The Calculator for the form 
        private void btnCal1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtResult.Text = txtResult.Text+ button.Text;
        }

        private void btnCalEnter_Click(object sender, EventArgs e)
        {
            txtTip.Text = txtResult.Text;
            double total = double.Parse(txtTip.Text.ToString()) + double.Parse(txtTotalPrice.Text.ToString());
            txtTotalPrice.Text = total.ToString("0.00");
            CheckTotalPrice();
            pnlCalculator.Hide();
        }
        private void btnEnterTotalPrice_Click(object sender, EventArgs e)
        {
            txtTotalPrice.Text = txtResult.Text;
            if (double.Parse(lblTotalBeforeTip.Text.ToString())< double.Parse(txtTotalPrice.Text.ToString()) )
            {
                double tip = double.Parse(txtTotalPrice.Text.ToString()) - double.Parse(lblTotalBeforeTip.Text.ToString());
                txtTip.Text = tip.ToString("0.00");
            }
            CheckTotalPrice();
            pnlCalculator.Hide();
        }
        //proceed to checkout button must be disabled if total price less than order
        void CheckTotalPrice()
        {
            if (double.Parse(lblTotalBeforeTip.Text.ToString()) > double.Parse(txtTotalPrice.Text.ToString()))
            {
                btnProceedToCheckout.Enabled = false;
            }
            else
            {
                btnProceedToCheckout.Enabled = true;    
            }
        }

        private void btnCalClear_Click(object sender, EventArgs e)
        {
           txtResult.Clear();
        }

        private void btnCalDel_Click(object sender, EventArgs e)
        {
            
            if (txtResult.Text.Length>0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
        }

        private void btnCalClose_Click(object sender, EventArgs e)
        {
            pnlCalculator.Hide();
            CheckTotalPrice();
        }

        // back button
        private void btnBackToPaymentHome_Click(object sender, EventArgs e)
        {
            pnlPaymentHomeScreen.Show();
            pnlPaymentOptions.Hide();
            pnlCalculator.Hide();
        }
        
        private void btnProceedToCheckout_Click(object sender, EventArgs e)
        {
            pnlPaymentOptions.Show();
            billService = new BillService();
        }

        //payment options buttons

        private void btnCash_Click(object sender, EventArgs e)
        {
            
            new PaymentOptions(billService, PaymentMethods.cash);
        }

        private void btnpin_Click(object sender, EventArgs e)
        {
            new PaymentOptions(billService, PaymentMethods.pin);
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            new PaymentOptions(billService, PaymentMethods.debitCard);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            new PaymentOptions(billService, PaymentMethods.credit);
        }

        private void btnMasterCard_Click(object sender, EventArgs e)
        {
            new PaymentOptions(billService, PaymentMethods.masterCard);
        }

        private void btnAmericanExpress_Click(object sender, EventArgs e)
        {
            new PaymentOptions(billService, PaymentMethods.americanExpress);
        }
    }
}
