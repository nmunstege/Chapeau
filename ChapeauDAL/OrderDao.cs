using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    public class OrderDao : BaseDao
    {
        OrderItemDao orderItemDao;
        TableDao tableDao;
        public OrderDao()
        {
             orderItemDao = new OrderItemDao();
            tableDao = new TableDao();
        }
        private List<Order> ReadTable(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach(DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["Order_no"];
                int userId = (int)dr["User_no"];
                //int billId = (int)dr["Bill_no"];
                int billId = 0;
                int tableId = (int)dr["Table_no"];
                Table table = tableDao.GetTableById((int)dr["Table_no"]);
                Order order = new Order(id, userId, tableId, billId,table);
                order.OrderItems = orderItemDao.GetOrderItemsByOrder(order);
                orders.Add(order);
                
            }
            return orders;
        }

        public Order GetOrderByOrderId(int orderId)
        {
            string query = "SELECT Order_no, User_no, Table_no, Bill_no " +
                               "FROM Orders " +
                               "WHERE Order_no = @orderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("orderId", orderId)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters))[0];

        }

        public Order GetOrderByTable(Table table)
        {
            string query = "SELECT Order_no, User_no, Bill_no, [Orders].Table_no, [Tables].Status " +
                           "FROM Orders " +
                           "INNER JOIN Tables " +
                           "ON [Orders].Table_no = [Tables].Table_no " +
                           "WHERE [Orders].Table_no = @tableId " +
                           "AND [Tables] Status = ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("tableId", table.Id)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }
    }
}
