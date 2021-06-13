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
        Bill bill;
        public Payment(int orderNr)
        {
            
            InitializeComponent();
            LoadPaymentHomeScreen(orderNr);
            
        }

        void LoadPaymentHomeScreen(int orderNr)
        {
            orderService = new OrderService();
            //show labels on the homescreen
            
            pnlPay.Hide();
            pnlCashPayment.Hide();
            pnlPaymentOptions.Hide();
            pnlCardPayment.Hide();
            pnlEndPayment.Hide();

            pnlPaymentHomeScreen.Show();

            bill = new Bill();
            bill.Order = orderService.GetOrder(1);
            lblTableNumber.Text = bill.Order.Table.Id.ToString();
            lblOrderId.Text = bill.Order.Id.ToString();

            //OrderItemService orderItemService = new OrderItemService();
           
           
            //fill list in order with orderitems 
            //orderItemService.FillOrderWithOrderItems(bill.Order);
            
            
               //Show order items

               ShowOrderItems(bill.Order.OrderItems);
            
            //show vat and total info
            double totalVAT= TotalVAT(bill.Order.OrderItems);
           double amountPayable= orderService.CalculateAmountPayable(totalVAT, bill.Order);
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
                ListViewItem orderitem = new ListViewItem(orderItem.Item.Name);
                orderitem.SubItems.Add(orderItem.Count.ToString());
                orderitem.SubItems.Add(orderItem.Item.Price.ToString("€0.00"));
                double Total = orderItem.Item.Price * orderItem.Count;
                orderitem.SubItems.Add(Total.ToString("€0.00"));
                orderitem.Tag = orderitem;
                lvOrderItems.Items.Add(orderitem);
            }
        }

        double TotalVAT(List<OrderItem>orderItems)
        {
            double vatHigh = 0;
            double vatLow = 0;
             
            foreach (OrderItem orderitem in orderItems)
            {
                double vatCalc = orderService.CalculateVat(orderitem);
                double lowVatCategory = orderService.LowVATCategory(orderitem.Item);
                if (orderitem.Item.VAT == lowVatCategory)
                {
                    vatLow += vatCalc;
                }
                else
                {
                    vatHigh += vatCalc;
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
            if (double.Parse(lblTotalBeforeTip.Text)< double.Parse(txtTotalPrice.Text) )
            {
                double tip = double.Parse(txtTotalPrice.Text) - double.Parse(lblTotalBeforeTip.Text);
                txtTip.Text = tip.ToString("0.00");
            }
            CheckTotalPrice();
            pnlCalculator.Hide();
        }
        //proceed to checkout button must be disabled if total price less than order
        void CheckTotalPrice()
        {
            if (double.Parse(lblTotalBeforeTip.Text) > double.Parse(txtTotalPrice.Text))
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

        // back button to payment home
        private void btnBackToPaymentHome_Click(object sender, EventArgs e)
        {
            pnlPaymentHomeScreen.Show();
            pnlPaymentOptions.Hide();
            pnlCalculator.Hide();
            pnlCardPayment.Hide();
            pnlCashPayment.Hide();
            pnlPay.Hide();
            pnlEndPayment.Hide();
        }
        
        private void btnProceedToCheckout_Click(object sender, EventArgs e)
        {

            BillService billService = new BillService();

            bill.OrderId = int.Parse(lblOrderId.Text);
            bill.TotalPrice = Decimal.Parse(txtTotalPrice.Text);
            if (txtTip.Text != "")
            {
                bill.Tip = Decimal.Parse(txtTip.Text);
            }
            else
            {
                bill.Tip = 0;
            }

            if (bill.Feedback == null)
            {
                bill.Feedback = " ";
            }
            bill.IsPaid = false;
            
            if (bill.paymentMethod == null)
            {
                bill.paymentMethod = " ";
            }
            bill.BillId = bill.Order.BillId;
            billService.AddBill(bill);

            LoadPaymentOptions();
        }

        void LoadPaymentOptions()
        {
            
            pnlCashPayment.Hide();
            pnlPay.Hide();
            pnlPaymentHomeScreen.Hide();
            pnlCalculator.Hide();
            pnlCardPayment.Hide();
            pnlEndPayment.Hide();

            pnlPaymentOptions.Show();
            lblPayOpOrderNr.Text = bill.OrderId.ToString();
            lblPayOpTableNr.Text = bill.Order.Table.Id.ToString();
        }

        //payment options buttons

        private void btnCash_Click(object sender, EventArgs e)
        {
            LoadCashPayment(PaymentMethods.cash);
        }

        private void btnpin_Click(object sender, EventArgs e)
        {
            LoadCardPayment(PaymentMethods.pin);
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            LoadCardPayment(PaymentMethods.debitCard);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            LoadCardPayment(PaymentMethods.credit);
        }

        private void btnMasterCard_Click(object sender, EventArgs e)
        {
            LoadCardPayment(PaymentMethods.masterCard);
        }

        private void btnAmericanExpress_Click(object sender, EventArgs e)
        {
            LoadCardPayment(PaymentMethods.americanExpress);
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            LoadCardPayment(PaymentMethods.visa);
        }
        void LoadCashPayment(PaymentMethods paymentMethod)
        {
            
            pnlPaymentHomeScreen.Hide();
            pnlCalculator.Hide();
            pnlPaymentOptions.Hide();
            pnlCardPayment.Hide();
            pnlEndPayment.Hide();

            pnlPay.Show();
            pnlCashPayment.Show();
            btnPay.Show();

            lblCashOrderNr.Text = bill.Order.ToString();
            lblCashTableId.Text = bill.Order.Table.Id.ToString();
            lblCashTotalPrice.Text = bill.TotalPrice.ToString();
            lblPayTitle.Text = "Cash Payment";

            bill.paymentMethod = paymentMethod.ToString();
        }

        private void btnCashCal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtCashEnter.Text = txtCashEnter.Text + button.Text;

            CheckEnteredCashPayment();
            CheckChangeAmount();
        }

        void CheckEnteredCashPayment()
        {
            if (txtCashEnter.Text != "")
            {
                if (double.Parse(txtCashEnter.Text) >= double.Parse(lblCashTotalPrice.Text))
                {
                    btnPay.Enabled = true;
                }
                else
                {
                    btnPay.Enabled = false;
                }
            }
            else
            {
                return;
            }
            
        }

        void CheckChangeAmount()
        {
            if (txtCashEnter.Text != "")
            {
                lblChange.Text = (bill.TotalPrice - Decimal.Parse(txtCashEnter.Text)).ToString("€0.00");
            }
            else
            {
                lblChange.Text = "0";
            }
        }
        private void btnCashClear_Click(object sender, EventArgs e)
        {
            txtCashEnter.Clear();
            CheckEnteredCashPayment();
            CheckChangeAmount();
        }

        private void btnCashDel_Click(object sender, EventArgs e)
        {
            if (txtCashEnter.Text.Length > 0)
            {
                txtCashEnter.Text = txtCashEnter.Text.Remove(txtCashEnter.Text.Length - 1, 1);
            }
            CheckEnteredCashPayment();
            CheckChangeAmount();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bill.IsPaid = true;
            LoadFinishPayment();
        }

        void LoadCardPayment(PaymentMethods paymentMethod)
        {
            pnlCashPayment.Hide();
            pnlPaymentOptions.Hide();
            pnlPaymentHomeScreen.Hide();
            pnlCalculator.Hide();
            pnlEndPayment.Hide();

            pnlPay.Show();
            pnlCardPayment.Show();
            
            lblPayTitle.Text = "Card Payment";
            btnPay.Hide();

             lblCashTableId.Text = bill.Order.Table.Id.ToString();
            lblCashOrderNr.Text = bill.Order.Id.ToString();
            lblCashTotalPrice.Text = bill.TotalPrice.ToString();
            bill.paymentMethod = paymentMethod.ToString();

            lblCardTotal.Text = bill.TotalPrice.ToString();

        }
        private void btnCardPayment_Click(object sender, EventArgs e)
        {
            bill.IsPaid = true;
            LoadFinishPayment();
        }

        private void btnBackToPaymentOptions_Click(object sender, EventArgs e)
        {
            pnlCashPayment.Hide();
            pnlPaymentHomeScreen.Hide();
            pnlCalculator.Hide();
            pnlPay.Hide();
            pnlCardPayment.Hide();
            pnlEndPayment.Hide();

            pnlPaymentOptions.Show();
        }

        void LoadFinishPayment()
        {
            pnlCashPayment.Hide();
            pnlPaymentHomeScreen.Hide();
            pnlCalculator.Hide();
            pnlPay.Hide();
            pnlCardPayment.Hide();
            pnlPaymentOptions.Hide();

            pnlEndPayment.Show();
             lblTableIdEnd.Text = bill.Order.Table.Id.ToString();
            lbltableIdEnd2.Text = lblTableIdEnd.Text;
            lblOrderNrEnd.Text = bill.OrderId.ToString();
            lblOrdernrEnd2.Text = lblOrderNrEnd.Text;
            
            // Freeing table in Database
            bill.Order.Table.Status = TableStatus.Empty;
            ShowOrderResult();
            BillService billService = new BillService();
            billService.UpdateBill(bill);
           
        }
        

        void ShowOrderResult()
        {
            if (bill.IsPaid == true)
            {
                lblEndPaymentResult.Text = "Successful";
            }
            else
            {
                lblEndPaymentResult.Text = "Unsuccessful";
            }

            if (bill.Order.Table.Status == TableStatus.Empty)
            {
                lblFreeTableEnd.Text = "Unoccupied";
            }
            else
            {
                lblFreeTableEnd.Text = "Still Occupied, freeing table unsuccessful";
            }

        }

        private void btnBackFinishPayment_Click(object sender, EventArgs e)
        {
            BillService billService = new BillService();
           
            if (txtFeedback.Text!= "")
            {
                bill.Feedback = txtFeedback.Text;
                billService.UpdateBill(bill);
            }
            
            // Show table overview
            
        }

        
    }
}
