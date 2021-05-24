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
    public class CategoryDao : BaseDao
    {
        private List<Category> ReadCategoryTable(DataTable dataTable)
        {
            List<Category> categories = new List<Category>();

            foreach(DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["Category_no"];
                string name = (string)dr["Name"];
                categories.Add(new Category(id, name));
            }
            return categories;          
        }

        public List<Category> GetAllCategories()
        {
            string query = "SELECT Category_no, Name " +
                           "FROM [Categories]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadCategoryTable(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
