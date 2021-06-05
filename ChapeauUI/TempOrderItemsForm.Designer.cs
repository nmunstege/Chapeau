
namespace ChapeauUI
{
    partial class TempOrderItemsForm
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
            this.lblAddItemHeader = new System.Windows.Forms.Label();
            this.orderItemFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddItemHeader
            // 
            this.lblAddItemHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddItemHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddItemHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddItemHeader.Location = new System.Drawing.Point(0, 0);
            this.lblAddItemHeader.Name = "lblAddItemHeader";
            this.lblAddItemHeader.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAddItemHeader.Size = new System.Drawing.Size(300, 25);
            this.lblAddItemHeader.TabIndex = 8;
            this.lblAddItemHeader.Text = "label1";
            this.lblAddItemHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderItemFlowLayoutPanel
            // 
            this.orderItemFlowLayoutPanel.AutoScroll = true;
            this.orderItemFlowLayoutPanel.AutoSize = true;
            this.orderItemFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderItemFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.orderItemFlowLayoutPanel.Location = new System.Drawing.Point(10, 35);
            this.orderItemFlowLayoutPanel.Name = "orderItemFlowLayoutPanel";
            this.orderItemFlowLayoutPanel.Size = new System.Drawing.Size(280, 310);
            this.orderItemFlowLayoutPanel.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Location = new System.Drawing.Point(190, 353);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(100, 35);
            this.btnSendOrder.TabIndex = 0;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // TempOrderItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.orderItemFlowLayoutPanel);
            this.Controls.Add(this.lblAddItemHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TempOrderItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TempOrderItemsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItemHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.FlowLayoutPanel orderItemFlowLayoutPanel;
    }
}