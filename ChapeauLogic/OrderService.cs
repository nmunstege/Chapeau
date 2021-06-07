using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDao orderDao;
     
        public OrderService()
        {
            orderDao = new OrderDao();
           
        }
    }
}
