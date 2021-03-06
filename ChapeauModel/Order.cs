using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        private int id;
        public int Id { get { return id; } }
        public int UserId { get; set; }
        public User User { get; set; }
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        

        public Order()
        {
            
        }

        public Order(int id, int userId, int billId, int tableId, Table table)
        {
           
            this.id = id;
            UserId = userId;
            BillId = billId;
            TableId = tableId;
            this.Table = table;
            
        }
        public Order(int id, User user, Bill bill, Table table)
        {
            this.id = id;
            User = user;
            Bill = bill;
            Table = table; 
        }
        // Create Constructor
        public Order(User user, Bill bill, Table table)
        {
            User = user;
            Bill = bill;
            Table = table; 
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
