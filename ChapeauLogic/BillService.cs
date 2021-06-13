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
        TableDao tableDao;
        public BillService()
        {
            billDao = new BillDao();
            tableDao = new TableDao();
        }

        public void  AddBill(Bill bill)
        {
            
                billDao.AddBill(bill);
            //billDao.SelectBill(bill.OrderId);

        }

        public void UpdateBill(Bill bill)
        {
            tableDao.EditTableStatus(bill.Order.Table, TableStatus.Empty);
            billDao.UpdateBill(bill);
        }

        //public void SelectBill(int billId)
        //{
            
        //}
    }
}
