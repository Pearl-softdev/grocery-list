using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_List
{
   public class Item
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public Item(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
