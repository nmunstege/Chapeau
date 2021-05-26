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
    public partial class CategoryWrapper : UserControl
    {
        SubCategoryService subCategoryService;
        ItemService itemService;

        bool IsActive { get; set; }
        public CategoryWrapper(SubCategory subCategory)
        {
            subCategoryService = new SubCategoryService();
            itemService = new ItemService();
            InitializeComponent();
            IsActive = false;
            DrawSubCategory(subCategory);
            
        }

        private void DrawSubCategory(SubCategory subCategory)
        {
            subCategoryFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            subCategoryFlowLayoutPanel.WrapContents = false;
            subCategoryFlowLayoutPanel.AutoSize = true;
            Button subCategoryButton = new Button()
            {
                Text = subCategory.Name,
                AutoSize = false,
                Width = 313,
                Height = 40,
                Location = new Point(0, 0),
                Margin = new Padding(0)
            };
            subCategoryFlowLayoutPanel.Controls.Add(subCategoryButton);
            subCategoryFlowLayoutPanel.Controls.Add(DrawSubCategoryItems(subCategory));

           
        }

        private FlowLayoutPanel DrawSubCategoryItems(SubCategory subCategory)
        {
            FlowLayoutPanel itemsFLowLayoutPanel = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoSize = true
            };
            foreach(Item item in itemService.GetItemsBySubCategory(subCategory))
            {
                ItemRow itemRow = new ItemRow(item);
                itemsFLowLayoutPanel.Controls.Add(itemRow);
            }
            return itemsFLowLayoutPanel;




        }
    }
}
