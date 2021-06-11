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
        public double Tip { get; set; }
        public double TotalPrice { get; set; }
        public PaymentMethods paymentMethod { get; set; }
        public bool IsPaid { get; set; }
        public Order Order { get; set; }
    }
}
