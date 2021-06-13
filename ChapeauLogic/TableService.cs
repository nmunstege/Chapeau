using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class TableService
    {
        TableDao tableDao;
        OrderDao orderDao;

        public TableService()
        {
            tableDao = new TableDao();
            orderDao = new OrderDao();

        }

        public List<Table> GetAllTables()
        {
            return tableDao.GetAllTables();
        }

        public void SetStatusToReserved(Table table)
        {
            tableDao.EditTableStatus(table, TableStatus.Reserved);
        }
        public void SetStatusToOrdered(Table table)
        {
            tableDao.EditTableStatus(table, TableStatus.Ordered);
        }
        public void SetStatusToEmpty(Table table)
        {
            tableDao.EditTableStatus(table, TableStatus.Empty);
        }
        public void FreeTable(Table table)
        {
           // tableDao.FreeTable(table);
        }


    }
}
