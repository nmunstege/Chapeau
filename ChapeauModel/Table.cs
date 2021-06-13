using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Table
    {
        public int TableId { get; set; }
        //public int Status { get; set; }
        public TableStatus Status { get; set; }
        public int Id { get; set; }


        public Table()
        {
        
        }

        public Table(int tableId, TableStatus status)
        {
            this.TableId = tableId;
            this.Status = status;
        }
    }

    public enum TableStatus
    {
        Empty = 1,
        Reserved,
        Ordered,
    }
}
