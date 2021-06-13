
namespace ChapeauUI
{
    partial class TableOverview
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTables = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableOverview = new System.Windows.Forms.Panel();
            this.listViewTableOrderItems = new System.Windows.Forms.ListView();
            this.btnServeOrders = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlTableOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 590);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(360, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Table Overview";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table Overview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlTables
            // 
            this.pnlTables.ColumnCount = 2;
            this.pnlTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTables.Location = new System.Drawing.Point(10, 55);
            this.pnlTables.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.RowCount = 5;
            this.pnlTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.pnlTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.pnlTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.pnlTables.Size = new System.Drawing.Size(340, 529);
            this.pnlTables.TabIndex = 7;
            // 
            // pnlTableOverview
            // 
            this.pnlTableOverview.Controls.Add(this.listViewTableOrderItems);
            this.pnlTableOverview.Controls.Add(this.btnServeOrders);
            this.pnlTableOverview.Controls.Add(this.btnTakeOrder);
            this.pnlTableOverview.Controls.Add(this.btnPayOrder);
            this.pnlTableOverview.Controls.Add(this.button2);
            this.pnlTableOverview.Location = new System.Drawing.Point(0, 48);
            this.pnlTableOverview.Name = "pnlTableOverview";
            this.pnlTableOverview.Size = new System.Drawing.Size(360, 536);
            this.pnlTableOverview.TabIndex = 8;
            this.pnlTableOverview.Visible = false;
            // 
            // listViewTableOrderItems
            // 
            this.listViewTableOrderItems.HideSelection = false;
            this.listViewTableOrderItems.Location = new System.Drawing.Point(12, 7);
            this.listViewTableOrderItems.Name = "listViewTableOrderItems";
            this.listViewTableOrderItems.Size = new System.Drawing.Size(336, 476);
            this.listViewTableOrderItems.TabIndex = 2;
            this.listViewTableOrderItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnServeOrders
            // 
            this.btnServeOrders.Location = new System.Drawing.Point(130, 497);
            this.btnServeOrders.Name = "btnServeOrders";
            this.btnServeOrders.Size = new System.Drawing.Size(100, 35);
            this.btnServeOrders.TabIndex = 1;
            this.btnServeOrders.Text = "Serve Orders";
            this.btnServeOrders.UseVisualStyleBackColor = true;
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Location = new System.Drawing.Point(10, 497);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(100, 35);
            this.btnTakeOrder.TabIndex = 1;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Location = new System.Drawing.Point(250, 497);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(100, 35);
            this.btnPayOrder.TabIndex = 1;
            this.btnPayOrder.Text = "Pay Order";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TableOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.pnlTableOverview);
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableOverview";
            this.Text = "TableOverview";
            this.pnlTableOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel pnlTables;
        private System.Windows.Forms.Panel pnlTableOverview;
        private System.Windows.Forms.ListView listViewTableOrderItems;
        private System.Windows.Forms.Button btnServeOrders;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.Button button2;
    }
}