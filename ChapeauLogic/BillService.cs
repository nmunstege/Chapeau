using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class BillService
    {
        BillDao billDao;
        public BillService()
        {
            billDao = new BillDao();
        }

        public void  AddBill(Bill bill)
        {
            
                billDao.AddBill(bill);
            //billDao.SelectBill(bill.OrderId);

        }

        public void UpdateBill(Bill bill)
        {
            billDao.UpdateBill(bill);
        }

        //public void SelectBill(int billId)
        //{
            
        //}
    }
}
