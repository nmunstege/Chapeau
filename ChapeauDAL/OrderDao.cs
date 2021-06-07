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
        private List<Order> ReadTable(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order orderInfo = new Order()
                {
                    UserId = (int)dr["User_no"],
                    TableId = (int)dr["Table_no"],
                    BillId = (int)dr["Bill_no"],
                   
                };
                orders.Add(orderInfo);
            }
            return orders;
        }

        public List<Order> GetOrderByOrderId(int orderId)
        {
            string query = "SELECT Order_no, Item_no, Bill_no " +
                               "FROM Orders " +
                               "WHERE Order_no = @orderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("orderId", orderId)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));

        }
    }
}
