using Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack
{
    public enum Manufacturer
    {
        KurtGeiger,
        Coccinelle,
        Hugo,
        Guess,
        MichaelKors,
    };
    public enum Fabric
    {
        Canvas,
        Gunny,
        Polyester,
        EcoLeather,
    };
    class Backpack : Container.Source
    {
        public RGB Color { get; private set; }
        public Manufacturer Manufacturer { get; private set; }
        public Fabric Fabric { get; private set; }
        public Backpack(RGB color, Manufacturer manufacturer, Fabric fabric, float weight, int volume) : base (weight, volume)
        {
            Color = color;
            Manufacturer = manufacturer;
            Fabric = fabric;
        }
    }
}
