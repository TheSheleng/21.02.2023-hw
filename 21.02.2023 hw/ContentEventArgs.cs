using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class ContentEventArgs
    {
        public string Msg { get; }
        public Item Item { get; }
        public ContentEventArgs(string msg, Item item)
        {
            Msg = msg;
            Item = item;
        }
    }
}
