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
        //private List<Table> ReadTable(DataTable dataTable)
        //{
        //    List<Table> tables = new List<Table>();
        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        Table table = new Table()
        //        {
        //            TableId = (int)dr["Table_no"],
        //            Status = (int)dr["Status"]
        //        };
        //        tables.Add(table);
        //    }
        //    return tables;
        //}
        public Table GetTableById(int tableId)
        {
            string query = "SELECT Table_no, Status " +
                               "FROM Tables " +
                               "WHERE Table_no = @TableNo";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TableNo", tableId)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters))[0];

        }

        private List<Table> ReadTable(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["Table_no"];
                TableStatus status = (TableStatus)dr["Status"];
                Table table = new Table()
                {
                    Id = id,
                    Status = status
                };

                tables.Add(table);
            }

            return tables;
        }

        public List<Table> GetAllTables()
        {
            string query = "SELECT Table_no, Status " +
                           "FROM Tables ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void EditTableStatus(Table table, TableStatus newStatus)
        {
            string query = " UPDATE [Tables] " +
                           " SET Status = @status " +
                           " WHERE Table_no = @tableId ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("status", (int)newStatus),
                new SqlParameter("tableId", table.Id)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
