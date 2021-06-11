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
        public bool Status { get; set; }

        public Table()
        {
        
        }

        public Table(int tableId,bool status)
        {
            this.TableId = tableId;
            this.Status = status;
        }
    }
}
