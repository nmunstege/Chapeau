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


        public double CalculateVat(OrderItem orderItem, Item item)
        {
            return  item.VATCalc(item) * orderItem.Count;
        }

        public double LowVATCategory(Item item)
        {
            SubCategoryService subCategoryService = new SubCategoryService();
           List<SubCategory>subCategories = subCategoryService.GetSubCategories();
            double lowest = item.VAT;
            
            foreach (SubCategory sub in subCategories)
            {
                
                if (sub.VAT > lowest)
                {
                    continue;
                }
                else if(sub.VAT<= lowest)
                {
                    lowest = sub.VAT;
                }
                
            }
            return lowest;
        }

        public double CalculateAmountPayable(double totalVAT,Order order)
        {
            double amountPayable = 0;
            foreach (OrderItem orderItem in order.OrderItems)
            {
                foreach (Item item in orderItem.Items)
                {
                    if (item.Id == orderItem.ItemId)
                    {
                        amountPayable += order.OrderItems.Count * item.Price;
                        break;
                    }
                    
                }
            }
            return amountPayable += totalVAT;
        }
    }
}
