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
        private List<OrderItem> ReadTable(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderId = (int)dr["Order_no"],
                    ItemId = (int)dr["Item_no"],
                    Status = (Status)dr["Order_no"],
                    Count = (int)dr["Count"],
                    Comment = (string)dr["Comment"],
                    TimeStamp = (DateTime)dr["Timestamp"]
                };

                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        private List<OrderItem> GetOrderItemsByOrder(Order)

    }
}
