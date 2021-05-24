using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class CategoryService
    {
        CategoryDao categoryDao;
        public CategoryService()
        {
            categoryDao = new CategoryDao();
        }

        public List<Category> GetAllCategories()
        {
            return categoryDao.GetAllCategories();
        }
    }
}
