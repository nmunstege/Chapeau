using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        OrderDao orderDao = new OrderDao();
        private List<Bill> ReadTable(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    BillId = (int)dr["Bill_no"],
                    OrderId = (int)dr["Order_no"],
                    Feedback = (string)dr["Feedback"],
                    Tip = (Decimal)dr["Tip"],
                    TotalPrice = (Decimal)dr["Total_Price"],
                    paymentMethod = (string)dr["Payment_Method"],
                    IsPaid = (bool)dr["Is_Payed"],
                    Order = orderDao.GetOrderByOrderId((int)dr["Order_no"])

                };
                bills.Add(bill);
            }
            return bills;
        }

        public void AddBill(Bill bill)
        {
            string query = "INSERT INTO Bills (Order_no,Feedback,Tip,Total_Price,Payment_Method,Is_Payed)" +
                           "VALUES(@Order_no, @Feedback, @Tip, @Total_Price, @Payment_Method, @Is_Payed) " +
                           "SELECT SCOPE_IDENTITY();";
            SqlParameter[] sqlParameters =
            {

                new SqlParameter("@Order_no", bill.OrderId),
                new SqlParameter("@Feedback", bill.Feedback),
                new SqlParameter("@Tip", bill.Tip),
                new SqlParameter("@Total_Price", bill.TotalPrice),
                new SqlParameter("@Payment_Method", bill.paymentMethod),
                new SqlParameter("@Is_Payed", bill.IsPaid)

            };

            
             ExecuteEditQuery(query, sqlParameters);

        }

        public void UpdateBill(Bill bill)
        {
            string query = "UPDATE Bills SET Order_no = @Order_no, Feedback = @Feedback,Tip = @Tip, Total_Price = @Total_Price, " +
                           "Payment_Method = @Payment_Method, Is_Payed = @Is_Payed " +
                           "WHERE Order_no = @Order_no";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Order_no", bill.OrderId),
                new SqlParameter("@Feedback", bill.Feedback.ToString()),
                new SqlParameter("@Tip", Convert.ToDecimal( bill.Tip)),
                new SqlParameter("@Total_Price", Convert.ToDecimal(bill.TotalPrice)),
                new SqlParameter("@Payment_Method", bill.paymentMethod.ToString()),
                new SqlParameter("@Is_Payed", bill.IsPaid)
            };
            ExecuteEditQuery(query, sqlParameters);

        }

        
    }
}



        

