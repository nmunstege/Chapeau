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
        public TableService()
        {
            tableDao = new TableDao();
        }

        public void FreeTable(Table table)
        {
            tableDao.FreeTable(table);
        }
    }
}
