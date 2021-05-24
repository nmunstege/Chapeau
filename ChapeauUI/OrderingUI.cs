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

            List<Category> categories = categoryService.GetAllCategories();

            foreach(Category category in categories)
            {
                test += category.Name + " ";
            }

            lblTest.Text = test;
        }
    }
}
