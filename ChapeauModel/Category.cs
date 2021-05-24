using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Category
    {
        int id;

        public int Id { get { return id; } }
        public string Name { get; set; }
        public Category(int id, string name)
        {
            this.id = id;
            Name = name;
        }
    }
}
