using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color
{
    struct RGB
    { 
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public RGB(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
        public override string ToString()
        {
            return $"R: {R}; G: {G}; B: {B};";
        }
    }
    static class Rainbow
    {
        static public RGB Red =    new RGB(255, 0, 0);
        static public RGB Orange = new RGB(255, 128, 0);
        static public RGB Yellow = new RGB(255, 255, 0);
        static public RGB Green =  new RGB(0, 255, 0);
        static public RGB Blue =   new RGB(0, 128, 255);
        static public RGB Indigo = new RGB(0, 0, 255);
        static public RGB Violet = new RGB(128, 0, 255);
    }
}
