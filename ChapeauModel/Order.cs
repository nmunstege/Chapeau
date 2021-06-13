using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapeauModel
{
    public class Order
    {
        int id;
        public int Id { get { return id; } set{ id = value; } }
        public int UserId { get; set; }
        public int BillId { get; set; }
        public int TableId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Table Table { get; set; }
        

        public Order()
        {
            
        }

        public Order(int id, int userId, int billId, int tableId,Table table)
        {
           
            this.id = id;
            UserId = userId;
            BillId = billId;
            TableId = tableId;
            this.Table = table;
            
        }
        public Order(int id, int userId, int billId, int tableId)
        {
           
            this.id = id;
            UserId = userId;
            BillId = billId;
            TableId = tableId;
            
        }


    }
}
