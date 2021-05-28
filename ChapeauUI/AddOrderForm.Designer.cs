
namespace ChapeauUI
{
    partial class AddOrderForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCancelAddOrder = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAddItemHeader = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.btnAddQuantity = new System.Windows.Forms.Button();
            this.btnRemoveQuantity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Add Comment?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 105);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 280);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add to Order";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddOrder
            // 
            this.btnCancelAddOrder.Location = new System.Drawing.Point(10, 280);
            this.btnCancelAddOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelAddOrder.Name = "btnCancelAddOrder";
            this.btnCancelAddOrder.Size = new System.Drawing.Size(100, 40);
            this.btnCancelAddOrder.TabIndex = 10;
            this.btnCancelAddOrder.Text = "Cancel";
            this.btnCancelAddOrder.UseVisualStyleBackColor = true;
            this.btnCancelAddOrder.Click += new System.EventHandler(this.btnCancelAddOrder_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 230);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(240, 40);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "label1";
            this.lblMessage.Click += new System.EventHandler(this.fuck_Click);
            // 
            // lblAddItemHeader
            // 
            this.lblAddItemHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddItemHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddItemHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddItemHeader.Location = new System.Drawing.Point(0, 0);
            this.lblAddItemHeader.Name = "lblAddItemHeader";
            this.lblAddItemHeader.Size = new System.Drawing.Size(260, 25);
            this.lblAddItemHeader.TabIndex = 7;
            this.lblAddItemHeader.Text = "label1";
            this.lblAddItemHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(105, 180);
            this.txtBoxQuantity.MinimumSize = new System.Drawing.Size(4, 35);
            this.txtBoxQuantity.Multiline = true;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(50, 35);
            this.txtBoxQuantity.TabIndex = 18;
            this.txtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.Location = new System.Drawing.Point(158, 180);
            this.btnAddQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(40, 35);
            this.btnAddQuantity.TabIndex = 17;
            this.btnAddQuantity.Text = "+";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            this.btnAddQuantity.Click += new System.EventHandler(this.btnAddQuantity_Click);
            // 
            // btnRemoveQuantity
            // 
            this.btnRemoveQuantity.Location = new System.Drawing.Point(62, 180);
            this.btnRemoveQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveQuantity.Name = "btnRemoveQuantity";
            this.btnRemoveQuantity.Size = new System.Drawing.Size(40, 35);
            this.btnRemoveQuantity.TabIndex = 16;
            this.btnRemoveQuantity.Text = "-";
            this.btnRemoveQuantity.UseVisualStyleBackColor = true;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 330);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.btnRemoveQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCancelAddOrder);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblAddItemHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCancelAddOrder;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblAddItemHeader;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.Button btnAddQuantity;
        private System.Windows.Forms.Button btnRemoveQuantity;
    }
}