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
    public class ItemDao : BaseDao
    {
        private List<Item> ReadTable(DataTable dataTable)
        {
            List<Item> items = new List<Item>();
            foreach(DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["Item_no"];
                string name = (string)dr["Name"];
                string description = (string)dr["Description"];
                double price = (double)dr["Price"];
                int quantity = (int)dr["Quantity"];
                int subCategory = (int)dr["SubCategory_no"];
                double vat = (double)dr["VAT"];

                items.Add(new Item(id, name, description, price, quantity, subCategory, vat));
            }
            return items;
        }

        public List<Item> GetItemBySubcategory(ChapeauModel.SubCategory subCategory)
        {
            string query = "SELECT Item_no, [Items].Name, Description, Price, Quantity, [Items].SubCategory_no, [SubCategories].VAT " +
                           "FROM [Items] " +
                           "INNER JOIN [SubCategories] " +
                           "ON [Items].SubCategory_no = [SubCategories].SubCategory_no " +
                           "WHERE [Items].SubCategory_no = @subCategory_no";
                           
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("subCategory_no", subCategory.Id)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));

        }

        public Item GetItem(Item item)
        {
            string query = "SELECT Item_no, [Items].Name, Description, Price, Quantity, [Items].SubCategory_no, [SubCategories].VAT " +
                           "FROM [Items]" +
                           "WHERE [Items].Item_no = @item_no";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("item_no", item.Id)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters))[0];

        }

        
    }
}
