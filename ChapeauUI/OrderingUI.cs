using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class OrderingUI : Form
    {
        ItemService itemService;
        CategoryService categoryService;
        SubCategoryService subCategoryService;
        public OrderingUI()
        {
            itemService = new ItemService();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();

            InitializeComponent();
            DrawMenuTabControl();
        }

        private void DrawMenuTabControl()
        {
            foreach(Category category in categoryService.GetAllCategories())
            {
                TabPage categoryTabPage = new TabPage();
                categoryTabPage.Text = category.Name;
                categoryTabPage.AutoScroll = true;
                categoryTabPage.Margin = new Padding(0);
                categoryTabPage.BackColor = Color.White;
                
                FlowLayoutPanel categoryFlowLayouPanel = new FlowLayoutPanel();
                categoryFlowLayouPanel.Width = 309;
                categoryFlowLayouPanel.AutoSize = true;
                categoryFlowLayouPanel.WrapContents = false;
                categoryFlowLayouPanel.FlowDirection = FlowDirection.TopDown;
                categoryFlowLayouPanel.Margin = new Padding(0);
                foreach(SubCategory subCategory in subCategoryService.GetSubCategoriesByCategory(category))
                {
                    CategoryWrapper categoryWrapper = new CategoryWrapper(subCategory);

                    
                    categoryFlowLayouPanel.Controls.Add(categoryWrapper);
                }
                categoryTabPage.Controls.Add(categoryFlowLayouPanel);
                tabControlMenu.TabPages.Add(categoryTabPage);
            }
        }



    }
}
