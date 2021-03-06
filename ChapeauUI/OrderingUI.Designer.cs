
namespace ChapeauUI
{
    partial class OrderingUI
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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowOrderTemp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.ItemSize = new System.Drawing.Size(110, 35);
            this.tabControlMenu.Location = new System.Drawing.Point(10, 55);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(340, 540);
            this.tabControlMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowOrderTemp
            // 
            this.btnShowOrderTemp.Location = new System.Drawing.Point(228, 12);
            this.btnShowOrderTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowOrderTemp.Name = "btnShowOrderTemp";
            this.btnShowOrderTemp.Size = new System.Drawing.Size(120, 35);
            this.btnShowOrderTemp.TabIndex = 4;
            this.btnShowOrderTemp.Text = "Table Overview";
            this.btnShowOrderTemp.Click += new System.EventHandler(this.btnShowOrderTemp_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 605);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(360, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Table Overview";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OrderingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnShowOrderTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderingUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderingUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowOrderTemp;
        private System.Windows.Forms.Button button3;
    }
}