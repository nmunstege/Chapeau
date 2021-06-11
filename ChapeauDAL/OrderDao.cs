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
    public class OrderDao : BaseDao
    {
        TableDao tableDao = new TableDao();
        private List<Order> ReadTable(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order orderInfo = new Order()
                {
                    //Id = (int)dr["Order_no"],
                    UserId = (int)dr["User_no"],
                    TableId = (int)dr["Table_no"],
                    //BillId = (int)dr["Bill_no"],
                  Table = tableDao.GetTableById((int)dr["Table_no"])
                };
                orders.Add(orderInfo);
            }
            return orders;
        }

        public Order GetOrderByOrderId(int orderId)
        {
            string query = "SELECT User_no, Table_no " +
                               "FROM Orders " +
                               "WHERE Order_no = @orderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("orderId", orderId)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters))[0];

        }
    }
}
