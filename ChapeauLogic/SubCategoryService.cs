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
    public class SubCategoryService
    {
        SubCategoryDao subCategoryDao;
        public SubCategoryService()
        {
            subCategoryDao = new SubCategoryDao();
        }

        public List<SubCategory> GetSubCategoriesByCategory(Category category)
        {
            return subCategoryDao.GetSubCategoriesByCategory(category);
        }
    }
}
