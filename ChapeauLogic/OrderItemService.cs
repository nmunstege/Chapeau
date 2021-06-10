﻿using System;
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
        

        public OrderItemService()
        {
            orderItemDao = new OrderItemDao();
        }
        
        public void AddOrderItem(List<OrderItem> orderItems)
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
