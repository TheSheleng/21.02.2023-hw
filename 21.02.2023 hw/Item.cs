using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class Item
    {
        public string Name { get; }
        public float Weight { get; }
        public Item(string name, float weight)
        {
            Name = name;
            Weight = weight;
        }
        public Item(Item item)
        {
            Name = item.Name;
            Weight = item.Weight;
        }
    }
}
