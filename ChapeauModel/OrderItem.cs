using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public Item Item { get; set; }
        public int ItemId { get; set; }
        public Status Status { get; set; }
        public int Count { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }

        public OrderItem(int itemId, int orderId, int count, string comment)
        {
            ItemId = itemId;
            OrderId = orderId;
            Count = count;
            Comment = comment;
        }

        public OrderItem(Item item, Order order, int count, string comment)
        {
            Item = item;
            Order = order;
            Count = count;
            Comment = comment;
        }

        public OrderItem()
        {
            //
        }
    }
}
