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
        public OrderingUI()
        {
            InitializeComponent();
            string test = "";

            CategoryService categoryService = new CategoryService();

            SubCategoryService subCategoryService = new SubCategoryService();
            ItemService itemService = new ItemService();

            List<Category> categories = categoryService.GetAllCategories();

            foreach(Category category in categories)
            {
                List<SubCategory> subCategories = subCategoryService.GetSubCategoriesByCategory(category);
                test += category.Name + "\n";
                foreach(SubCategory subCategory in subCategories)
                {
                    test += subCategory.Name + "\n";
                    List<Item> items = itemService.GetItemsBySubCategory(subCategory);
                    foreach(Item item in items)
                    {
                        test += $"{item.Name}  ({item.Price}) \n";
                    }
                }
                test += "\n";
            }

            lblTest.Text = test;
        }
    }
}
