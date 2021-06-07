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
        OrderItemDao orderItemDao;
        List<OrderItem> orderItems;
        Order order;

        public OrderItemService()
        {
            orderItemDao = new OrderItemDao();
            orderItems = new List<OrderItem>();
        }
        
        public List<OrderItem> AddOrderItemtoTemp(Order order, Item item, int count, string comment)
        {
            OrderItem orderItem = new OrderItem(item.Id, order.Id, count, comment);
            orderItems.Add(orderItem);
            return orderItems;
        }
        public void AddOrderItem()
        {
           foreach(OrderItem orderItem in orderItems)
            {
                orderItemDao.AddOrderItem(orderItem);
            }
        }

        public void FillOrderWithOrderItems(Order order)
        {
             order.OrderItems= orderItemDao.GetOrderItemsByOrder(order);
        }
    }
}
