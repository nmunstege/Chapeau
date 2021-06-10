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
        public OrderItemService orderItemService;
        List<FlowLayoutPanel> itemWrappers = new List<FlowLayoutPanel>();
        public Item SelectedItem { get; set; }
        public List<OrderItem> TempOrderItems { get; set; }
        public Order CurrentOrder { get; set; }
        public OrderingUI(Order order)
        {
            itemService = new ItemService();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
            CurrentOrder = order;
            TempOrderItems = new List<OrderItem>();
            

            InitializeComponent();
            DrawMenuTabControl();
        }




        private void DrawMenuTabControl()
        {
            //
            // Nazirou
            // Draws Each main Category Tab Pages (Dinner, Lunch, and Drinks)
            foreach (Category category in categoryService.GetAllCategories())
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
                //
                // Nazirou
                // Draws each Sub Category Button in FlowPanel
                foreach (SubCategory subCategory in subCategoryService.GetSubCategoriesByCategory(category))
                {
                    FlowLayoutPanel subCategoryWrapper = new FlowLayoutPanel();
                    subCategoryWrapper.Width = 309;
                    subCategoryWrapper.AutoSize = true;
                    subCategoryWrapper.WrapContents = false;
                    subCategoryWrapper.FlowDirection = FlowDirection.TopDown;
                    subCategoryWrapper.Margin = new Padding(0);
                    Button subCategoryButton = new Button()
                    {
                        Text = subCategory.Name,
                        AutoSize = false,
                        Width = 309,
                        Height = 40,
                        Location = new Point(0, 0),
                        Margin = new Padding(0),
                        Tag = subCategory,
                        
                    };
                    subCategoryButton.Click += new EventHandler(subCategoryButton_Click);

                    subCategoryWrapper.Controls.Add(subCategoryButton);
                    //
                    // Nazirou
                    // Draws list of ItemRows for each Item in sub category in itemsWrapper FlowPannel
                    FlowLayoutPanel itemsWrapper = new FlowLayoutPanel()
                    {
                        FlowDirection = FlowDirection.TopDown,
                        WrapContents = false,
                        AutoSize = true,
                        Tag = subCategory
                    };
                    itemsWrapper.Hide();
                    itemWrappers.Add(itemsWrapper);

                    foreach (Item item in itemService.GetItemsBySubCategory(subCategory))
                    {
                        ItemRow itemRow = new ItemRow(item, CurrentOrder);
                        itemsWrapper.Controls.Add(itemRow);
                        

                    }

                    subCategoryWrapper.Controls.Add(itemsWrapper);

                    
                    categoryFlowLayouPanel.Controls.Add(subCategoryWrapper);
                }
                categoryTabPage.Controls.Add(categoryFlowLayouPanel);
                tabControlMenu.TabPages.Add(categoryTabPage);
            }
        }

        private void subCategoryButton_Click(object sender, EventArgs e)
        {
            foreach(FlowLayoutPanel itemWrapper in itemWrappers)
            {
                if((SubCategory)itemWrapper.Tag == (sender as Button).Tag)
                {
                    itemWrapper.Show();
                }else
                {
                    itemWrapper.Hide();
                }
            }
        }

        private void btnShowOrderTemp_Click(object sender, EventArgs e)
        {
            TempOrderItemsForm orderItemsForm = new TempOrderItemsForm(this);
            orderItemsForm.ShowDialog();
        }

        //private void AddOrderItem_ButtonClick(object sender, EventArgs e)
        //{
        //    Item item = (Item)(sender as Button).Tag;
        //    Order order = (Order)this.ParentForm.Tag;
        //    AddOrderForm addOrderForm = new AddOrderForm(item, order);

        //    addOrderForm.Show();
        //    this.OrderItems.AddRange(addOrderForm.OrderItems); 
        //}



    }
}
