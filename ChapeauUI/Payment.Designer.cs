
namespace ChapeauUI
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPaymentHomeScreen = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lvOrderItems = new System.Windows.Forms.ListView();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Total = new System.Windows.Forms.ColumnHeader();
            this.btnProceedToCheckout = new System.Windows.Forms.Button();
            this.lblTotalBeforeTip = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLowVat = new System.Windows.Forms.Label();
            this.lblHighVat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPaymentHomeScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaymentHomeScreen
            // 
            this.pnlPaymentHomeScreen.Controls.Add(this.btnProceedToCheckout);
            this.pnlPaymentHomeScreen.Controls.Add(this.lblTotalBeforeTip);
            this.pnlPaymentHomeScreen.Controls.Add(this.label9);
            this.pnlPaymentHomeScreen.Controls.Add(this.label8);
            this.pnlPaymentHomeScreen.Controls.Add(this.txtTip);
            this.pnlPaymentHomeScreen.Controls.Add(this.txtTotalPrice);
            this.pnlPaymentHomeScreen.Controls.Add(this.label4);
            this.pnlPaymentHomeScreen.Controls.Add(this.lblLowVat);
            this.pnlPaymentHomeScreen.Controls.Add(this.lblHighVat);
            this.pnlPaymentHomeScreen.Controls.Add(this.label5);
            this.pnlPaymentHomeScreen.Controls.Add(this.label6);
            this.pnlPaymentHomeScreen.Controls.Add(this.label7);
            this.pnlPaymentHomeScreen.Controls.Add(this.lblOrderId);
            this.pnlPaymentHomeScreen.Controls.Add(this.lblUserId);
            this.pnlPaymentHomeScreen.Controls.Add(this.label3);
            this.pnlPaymentHomeScreen.Controls.Add(this.label2);
            this.pnlPaymentHomeScreen.Controls.Add(this.lblTableNumber);
            this.pnlPaymentHomeScreen.Controls.Add(this.label1);
            this.pnlPaymentHomeScreen.Controls.Add(this.button1);
            this.pnlPaymentHomeScreen.Controls.Add(this.lvOrderItems);
            this.pnlPaymentHomeScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlPaymentHomeScreen.Name = "pnlPaymentHomeScreen";
            this.pnlPaymentHomeScreen.Size = new System.Drawing.Size(393, 807);
            this.pnlPaymentHomeScreen.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(221, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "order number:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderId.Location = new System.Drawing.Point(352, 59);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(32, 32);
            this.lblOrderId.TabIndex = 9;
            this.lblOrderId.Text = "..";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserId
            // 
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserId.Location = new System.Drawing.Point(352, 27);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(29, 23);
            this.lblUserId.TabIndex = 8;
            this.lblUserId.Text = "..";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(299, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "user:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(154, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.Location = new System.Drawing.Point(128, 17);
            this.lblTableNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(30, 36);
            this.lblTableNumber.TabIndex = 5;
            this.lblTableNumber.Text = "0";
            this.lblTableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(9, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lvOrderItems
            // 
            this.lvOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.lvOrderItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvOrderItems.HideSelection = false;
            this.lvOrderItems.Location = new System.Drawing.Point(12, 107);
            this.lvOrderItems.Name = "lvOrderItems";
            this.lvOrderItems.Size = new System.Drawing.Size(369, 371);
            this.lvOrderItems.TabIndex = 1;
            this.lvOrderItems.UseCompatibleStateImageBehavior = false;
            this.lvOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Name = "Item";
            this.Item.Text = "Item";
            this.Item.Width = 175;
            // 
            // Quantity
            // 
            this.Quantity.Name = "Quantity";
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Name = "Price";
            this.Price.Text = "Price";
            // 
            // Total
            // 
            this.Total.Name = "Total";
            this.Total.Text = "Total";
            // 
            // btnProceedToCheckout
            // 
            this.btnProceedToCheckout.Location = new System.Drawing.Point(254, 743);
            this.btnProceedToCheckout.Name = "btnProceedToCheckout";
            this.btnProceedToCheckout.Size = new System.Drawing.Size(123, 57);
            this.btnProceedToCheckout.TabIndex = 24;
            this.btnProceedToCheckout.Text = "&Proceed to Checkout";
            this.btnProceedToCheckout.UseVisualStyleBackColor = true;
            // 
            // lblTotalBeforeTip
            // 
            this.lblTotalBeforeTip.AutoSize = true;
            this.lblTotalBeforeTip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBeforeTip.Location = new System.Drawing.Point(349, 589);
            this.lblTotalBeforeTip.Name = "lblTotalBeforeTip";
            this.lblTotalBeforeTip.Size = new System.Drawing.Size(32, 28);
            this.lblTotalBeforeTip.TabIndex = 23;
            this.lblTotalBeforeTip.Text = "....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(188, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "Amount Payable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(188, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Add Tip";
            // 
            // txtTip
            // 
            this.txtTip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(309, 637);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(68, 34);
            this.txtTip.TabIndex = 20;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Location = new System.Drawing.Point(309, 688);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(68, 34);
            this.txtTotalPrice.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(188, 687);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "&Total Price";
            // 
            // lblLowVat
            // 
            this.lblLowVat.AutoSize = true;
            this.lblLowVat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLowVat.Location = new System.Drawing.Point(349, 537);
            this.lblLowVat.Name = "lblLowVat";
            this.lblLowVat.Size = new System.Drawing.Size(28, 28);
            this.lblLowVat.TabIndex = 17;
            this.lblLowVat.Text = "....";
            // 
            // lblHighVat
            // 
            this.lblHighVat.AutoSize = true;
            this.lblHighVat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighVat.Location = new System.Drawing.Point(349, 493);
            this.lblHighVat.Name = "lblHighVat";
            this.lblHighVat.Size = new System.Drawing.Size(24, 28);
            this.lblHighVat.TabIndex = 16;
            this.lblHighVat.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(188, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Low VAT at 21%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(188, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "High VAT at 6%";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 806);
            this.Controls.Add(this.pnlPaymentHomeScreen);
            this.Name = "Payment";
            this.Text = "Payment";
            this.pnlPaymentHomeScreen.ResumeLayout(false);
            this.pnlPaymentHomeScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPaymentHomeScreen;
        private System.Windows.Forms.ListView lvOrderItems;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnProceedToCheckout;
        private System.Windows.Forms.Label lblTotalBeforeTip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLowVat;
        private System.Windows.Forms.Label lblHighVat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}