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
        public Item SelectedItem { get; set; }
        
        public List<OrderItem> TempOrderItems { get; set; }

        public Order CurrentOrder { get; set; }
        public OrderingUI(Order order)
        {
            itemService = new ItemService();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
            CurrentOrder = order;

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
                        Tag = subCategory
                    };
                    subCategoryWrapper.Controls.Add(subCategoryButton);


                    FlowLayoutPanel itemsWrapper = new FlowLayoutPanel()
                    {
                        FlowDirection = FlowDirection.TopDown,
                        WrapContents = false,
                        AutoSize = true
                    };

                    foreach (Item item in itemService.GetItemsBySubCategory(subCategory))
                    {
                        ItemRow itemRow = new ItemRow(item);
                        itemsWrapper.Controls.Add(itemRow);
                        itemRow.ButtonClick += new EventHandler(addItem_ButtonClick);
                    }

                    subCategoryWrapper.Controls.Add(itemsWrapper);

                    //CategoryWrapper categoryWrapper = new CategoryWrapper(subCategory);
                    categoryFlowLayouPanel.Controls.Add(subCategoryWrapper);
                }
                categoryTabPage.Controls.Add(categoryFlowLayouPanel);
                tabControlMenu.TabPages.Add(categoryTabPage);
            }
        }

        private void addItem_ButtonClick(object sender, EventArgs e)
        {
            //Order order = CurrentOrder;
            //AddOrderForm addOrderForm = new AddOrderForm(item, order);

            //addOrderForm.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            orderItemService.AddOrderItem();
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
