using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Container
{
    class Source
    {
        public List<Item> Content { get; }
        public int MaxVolume { get; }
        public float MaxWeight { get; }
        public float Weight { get; private set; } = 0;
        public Source (float weight, int volume) 
        { 
            MaxWeight = weight;
            MaxVolume = volume;
            Content = new List<Item>(MaxVolume);
        }
        public delegate void ContentHendler(Source sender, ContentEventArgs e);
        public event ContentHendler ContentNotify;
        public void Put(Item item)
        {
            if (MaxWeight < Weight + item.Weight) throw new ContentException("Not enough Weight", item);
            if (MaxVolume < Content.Count + 1) throw new ContentException("Not enough Count", item);
            Content.Add(item);
            Weight += item.Weight;
            ContentNotify?.Invoke(this, new ContentEventArgs("The item has been put.", item));
        }   
        public Item Get(int index)
        {
            Item item = new Item(Content.ElementAt(index));
            Content.RemoveAt(index);
            Weight -= item.Weight;
            ContentNotify?.Invoke(this, new ContentEventArgs("The item has been gotten.", item));
            return item;
        }
    }
}
