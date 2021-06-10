using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderItemService
    {
        private OrderItemDao orderItemDao;
        private ItemDao itemDao;

        public OrderItemService()
        {
            orderItemDao = new OrderItemDao();
            itemDao = new ItemDao();
        }
        
        public void AddOrderItem(List<OrderItem> orderItems)
        {
           foreach(OrderItem orderItem in orderItems)
            {
                orderItem.Item = itemDao.GetItemById(orderItem.Item.Id);
                orderItemDao.AddOrderItem(orderItem);
            }
        }

        public void FillOrderWithOrderItems(Order order)
        {
             order.OrderItems= orderItemDao.GetOrderItemsByOrder(order);
        }
    }
}
