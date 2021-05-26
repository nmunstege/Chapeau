using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class SubCategory
    {
        private int id;
        public int Id { get { return id; } }
        public string Name { get; set; }
        public int Category_Id { get; set; }
        public double VAT { get; set; }
        public SubCategory()
        {
            //
        }

        public SubCategory(int id, string name, int category_id, double vat)
        {
            this.id = id;
            Name = name;
            Category_Id = category_id;
            VAT = vat;
        }
    }
}
