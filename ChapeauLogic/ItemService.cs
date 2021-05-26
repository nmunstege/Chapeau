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
    public class ItemService
    {
        ItemDao itemDao;
        SubCategory SubCategory { get; set; }
        public ItemService()
        {
            itemDao = new ItemDao();
        }

        public List<Item> GetItemsBySubCategory(SubCategory subCategory)
        {
            SubCategory = subCategory;
            List<Item> items = itemDao.GetItemBySubcategory(subCategory);
            return items;
        }

        public Item GetItem(Item item)
        {
            return itemDao.GetItem(item);
        }
    }
}
