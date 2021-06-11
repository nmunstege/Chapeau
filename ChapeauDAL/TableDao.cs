using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class TableDao: BaseDao
    {
        private List<Table> ReadTable(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableId = (int)dr["Table_no"],
                    Status = (bool)dr["Status"]
                };
                tables.Add(table);
            }
            return tables;
        }
        public Table GetTableById(int tableId)
        {
            string query = "SELECT [Table_no], Status" +
                               "FROM Tables" +
                               "WHERE [Table_no] = @TableNo";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TableNo", tableId)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters))[0];

        }
    }
}
