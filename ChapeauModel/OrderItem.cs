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
        public int ItemId { get; set; }
        public Status Status { get; set; }
        public int Count { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }

        public OrderItem(int orderId, int itemId, int status, int count, DateTime timeStamp)
        {
            OrderId = orderId;
            ItemId = itemId;
            Status = (Status)status;
            Count = count;
            TimeStamp = TimeStamp;
        }

        public OrderItem()
        {
            //
        }
    }
}
