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
        public OrderDao()
        {
             orderItemDao = new OrderItemDao(); 
        }
        private List<Order> ReadTable(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach(DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["Order_no"];
                int tableId = (int)dr["Table_no"];
                int userId = (int)dr["User_no"];
                int billId = (int)dr["Bill_no"];
                Order order = new Order(id, userId, tableId, billId);
                order.OrderItems = orderItemDao.GetOrderItemsByOrder(order);
                orders.Add(order);
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
