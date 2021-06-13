using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Bill
    {
        public int BillId { get; set; }
        public int OrderId { get; set; }
        public string Feedback { get; set; }
        public Decimal Tip { get; set; }
        public Decimal TotalPrice { get; set; }
        public string paymentMethod { get; set; }
        public bool IsPaid { get; set; }
        public Order Order { get; set; }
    }
}
