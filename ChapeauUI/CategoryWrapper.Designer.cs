
namespace ChapeauUI
{
    partial class CategoryWrapper
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subCategoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // subCategoryFlowLayoutPanel
            // 
            this.subCategoryFlowLayoutPanel.AutoSize = true;
            this.subCategoryFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.subCategoryFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.subCategoryFlowLayoutPanel.Name = "subCategoryFlowLayoutPanel";
            this.subCategoryFlowLayoutPanel.Size = new System.Drawing.Size(309, 56);
            this.subCategoryFlowLayoutPanel.TabIndex = 0;
            // 
            // CategoryWrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.subCategoryFlowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CategoryWrapper";
            this.Size = new System.Drawing.Size(309, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel subCategoryFlowLayoutPanel;
    }
}
