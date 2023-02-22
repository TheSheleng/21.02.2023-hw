using Color;
using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._2023_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source container = new Source(10, 5);
            container.ContentNotify += (sender, e) => 
            { 
                Console.WriteLine($"{e.Msg}; {e.Item.Name}");
            };

            container.Put(new Item("Pickaxe", 3));
            container.Get(0);

            Console.ReadKey();
        }
    }
}
