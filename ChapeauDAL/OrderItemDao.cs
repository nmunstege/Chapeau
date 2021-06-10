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
    
    public class OrderItemDao : BaseDao
    {
        ItemDao itemDao = new ItemDao();
        private List<OrderItem> ReadTable(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderId = (int)dr["Order_no"],
                    ItemId = (int)dr["Item_no"],
                    Status = (Status)dr["Status"],
                    Count = (int)dr["Count"],
                    Comment = (string)dr["Comment"],
                    TimeStamp = (DateTime)dr["Timestamp"],
                    Item =itemDao.GetItemsInOrder((int)dr["Item_no"])
                   
                };

                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        public List<OrderItem> GetOrderItemsByOrder(Order order)
        {
            string query = "SELECT Order_no, Item_no, Status, Count, Comment, Timestamp " +
                           "FROM Orders_Items " +
                           "WHERE Order_no = @orderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("orderId", order.Id)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        

        public void AddOrderItem(OrderItem orderItem)
        {
            string query = "INSERT INTO Orders_Items (Item_no, Order_no, Status, Count, Comment) " +
                           "VALUES (@itemId, @orderId, 1, @count, @comment)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("itemId", orderItem.Item.Id),
                new SqlParameter("orderId", orderItem.Order.Id),
                new SqlParameter("count", orderItem.Count),
                new SqlParameter("comment", orderItem.Comment){ IsNullable = true}
            };

            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
