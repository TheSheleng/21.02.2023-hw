using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Container
{
    class ContentException : Exception
    {
        public Item Item { get; }
        public ContentException(string mess, Item item) : base(mess) => this.Item = item;
    }
}
