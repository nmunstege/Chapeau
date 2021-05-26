using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Item
    {
        int id;
        double price;
        public int Id { get { return id; } }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get { return price + (price * (VAT / 100)); } set { price = value; } }
        public int Quantity { get; set; }
        public int SubCategory { get; set; }
        private double VAT { get; set; }

        public Item()
        {
            //
        }

        public Item(int id, string name, string description, double price, int quantity, int subCategory, double vat)
        {
            this.id = id;
            Name = name;
            this.price = price;
            Description = description;
            Quantity = quantity;
            SubCategory = subCategory;
            VAT = vat;
        }
    }
}
