
namespace ChapeauUI
{
    partial class KitchenUI
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
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.pnlOrderItems = new System.Windows.Forms.Panel();
            this.pnlOrderItemDetails = new System.Windows.Forms.Panel();
            this.btnSeeAllMeals = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.lblTitleTableNum = new System.Windows.Forms.Label();
            this.listViewMenuItems = new System.Windows.Forms.ListView();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lblOrderItemStatus = new System.Windows.Forms.Label();
            this.lblTitleOrderItem = new System.Windows.Forms.Label();
            this.pnlOrders.SuspendLayout();
            this.pnlOrderItems.SuspendLayout();
            this.pnlOrderItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.listViewOrders);
            this.pnlOrders.Controls.Add(this.btnSeeAllMeals);
            this.pnlOrders.Location = new System.Drawing.Point(13, 90);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(332, 514);
            this.pnlOrders.TabIndex = 0;
            this.pnlOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlOrderItems
            // 
            this.pnlOrderItems.Controls.Add(this.listViewMenuItems);
            this.pnlOrderItems.Controls.Add(this.lblTitleTableNum);
            this.pnlOrderItems.Location = new System.Drawing.Point(403, 90);
            this.pnlOrderItems.Name = "pnlOrderItems";
            this.pnlOrderItems.Size = new System.Drawing.Size(332, 514);
            this.pnlOrderItems.TabIndex = 1;
            // 
            // pnlOrderItemDetails
            // 
            this.pnlOrderItemDetails.Controls.Add(this.lblTitleOrderItem);
            this.pnlOrderItemDetails.Controls.Add(this.lblOrderItemStatus);
            this.pnlOrderItemDetails.Controls.Add(this.btnChangeStatus);
            this.pnlOrderItemDetails.Location = new System.Drawing.Point(793, 90);
            this.pnlOrderItemDetails.Name = "pnlOrderItemDetails";
            this.pnlOrderItemDetails.Size = new System.Drawing.Size(332, 514);
            this.pnlOrderItemDetails.TabIndex = 1;
            // 
            // btnSeeAllMeals
            // 
            this.btnSeeAllMeals.Location = new System.Drawing.Point(0, 0);
            this.btnSeeAllMeals.Name = "btnSeeAllMeals";
            this.btnSeeAllMeals.Size = new System.Drawing.Size(332, 53);
            this.btnSeeAllMeals.TabIndex = 0;
            this.btnSeeAllMeals.Text = "See All Meals";
            this.btnSeeAllMeals.UseVisualStyleBackColor = true;
            // 
            // listViewOrders
            // 
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(0, 78);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(332, 436);
            this.listViewOrders.TabIndex = 1;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // lblTitleTableNum
            // 
            this.lblTitleTableNum.AutoSize = true;
            this.lblTitleTableNum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleTableNum.Location = new System.Drawing.Point(20, 20);
            this.lblTitleTableNum.Name = "lblTitleTableNum";
            this.lblTitleTableNum.Size = new System.Drawing.Size(79, 31);
            this.lblTitleTableNum.TabIndex = 0;
            this.lblTitleTableNum.Text = "label1";
            // 
            // listViewMenuItems
            // 
            this.listViewMenuItems.FullRowSelect = true;
            this.listViewMenuItems.HideSelection = false;
            this.listViewMenuItems.Location = new System.Drawing.Point(0, 78);
            this.listViewMenuItems.Name = "listViewMenuItems";
            this.listViewMenuItems.Size = new System.Drawing.Size(332, 436);
            this.listViewMenuItems.TabIndex = 2;
            this.listViewMenuItems.UseCompatibleStateImageBehavior = false;
            this.listViewMenuItems.View = System.Windows.Forms.View.Details;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(208, 446);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(112, 54);
            this.btnChangeStatus.TabIndex = 0;
            this.btnChangeStatus.Text = "button1";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lblOrderItemStatus
            // 
            this.lblOrderItemStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderItemStatus.Location = new System.Drawing.Point(0, 7);
            this.lblOrderItemStatus.Name = "lblOrderItemStatus";
            this.lblOrderItemStatus.Size = new System.Drawing.Size(332, 31);
            this.lblOrderItemStatus.TabIndex = 3;
            this.lblOrderItemStatus.Text = "label1";
            // 
            // lblTitleOrderItem
            // 
            this.lblTitleOrderItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleOrderItem.Location = new System.Drawing.Point(0, 38);
            this.lblTitleOrderItem.Name = "lblTitleOrderItem";
            this.lblTitleOrderItem.Size = new System.Drawing.Size(332, 94);
            this.lblTitleOrderItem.TabIndex = 4;
            this.lblTitleOrderItem.Text = "label1";
            this.lblTitleOrderItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KitchenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 626);
            this.Controls.Add(this.pnlOrderItemDetails);
            this.Controls.Add(this.pnlOrderItems);
            this.Controls.Add(this.pnlOrders);
            this.Name = "KitchenUI";
            this.Text = "KitchenUI";
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrderItems.ResumeLayout(false);
            this.pnlOrderItems.PerformLayout();
            this.pnlOrderItemDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlOrderItems;
        private System.Windows.Forms.Panel pnlOrderItemDetails;
        private System.Windows.Forms.Button btnSeeAllMeals;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ListView listViewMenuItems;
        private System.Windows.Forms.Label lblTitleTableNum;
        private System.Windows.Forms.Label lblTitleOrderItem;
        private System.Windows.Forms.Label lblOrderItemStatus;
        private System.Windows.Forms.Button btnChangeStatus;
    }
}