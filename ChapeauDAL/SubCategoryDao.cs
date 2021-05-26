using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.ObjectModel;
using ChapeauModel;

namespace ChapeauDAL
{
    public class SubCategoryDao : BaseDao
    {
        private List<ChapeauModel.SubCategory> ReadTable(DataTable dataTable)
        {
            List<ChapeauModel.SubCategory> subCategories = new List<ChapeauModel.SubCategory>();
            foreach(DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["SubCategory_no"];
                int category_id = (int)dr["Category_no"];
                string name = (string)dr["Name"];
                double vat = (double)dr["VAT"];

                subCategories.Add(new SubCategory(id, name, category_id, vat));
            }

            return subCategories;
        }
        public List<ChapeauModel.SubCategory> GetSubCategoriesByCategory(Category category)
        {
            string query = "SELECT SubCategory_no, Category_no, Name, VAT " +
                           "FROM [SubCategories] " +
                           "WHERE Category_no = @category_no";
            SqlParameter[] sqlParameters =
            {
                    new SqlParameter("category_no", category.Id)
                };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
