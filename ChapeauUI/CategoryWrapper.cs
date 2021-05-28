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
        Button subCategoryButton;
        SubCategory currentSubCategory;
        List<FlowLayoutPanel> flowLayoutPanels = new List<FlowLayoutPanel>();

        
        public CategoryWrapper(SubCategory subCategory)
        {
            subCategoryService = new SubCategoryService();
            itemService = new ItemService();
            InitializeComponent();
           
            DrawSubCategory(subCategory);

        }
        private void subCategoryButton_Click(object sender, EventArgs e)
        {
            foreach(FlowLayoutPanel panel in flowLayoutPanels)
            {
                if(panel.Tag == (sender as Button).Tag)
                {
                    if(panel.Visible == false)
                    {
                        panel.Show();
                    }else
                    {
                        panel.Hide();
                    }
                } 
            }
            
        }

        private void DrawSubCategory(SubCategory subCategory)
        {
            subCategoryFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            subCategoryFlowLayoutPanel.WrapContents = false;
            subCategoryFlowLayoutPanel.AutoSize = true;
            subCategoryButton = new Button()
            {
                Text = subCategory.Name,
                AutoSize = false,
                Width = 309,
                Height = 40,
                Location = new Point(0, 0),
                Margin = new Padding(0),
                Tag = subCategory
            };

            
            subCategoryButton.Click += new EventHandler(subCategoryButton_Click);
            subCategoryFlowLayoutPanel.Controls.Add(subCategoryButton);

            FlowLayoutPanel itemsFlowPanel = DrawSubCategoryItems(subCategory);
            itemsFlowPanel.Tag = subCategory;
            itemsFlowPanel.Hide();
            flowLayoutPanels.Add(itemsFlowPanel);

            subCategoryFlowLayoutPanel.Controls.Add(itemsFlowPanel);  
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
