using System;

namespace ColorSpheres
{
    public class Program
    {
        public class Color
        {
            private byte red;
            private byte green;
            private byte blue;
            
            public byte Red
            {
                get { return red; }
                set { red = value; }
            }
            public byte Green
            {
                get { return green; }
                set { green = value; }
            }
            public byte Blue 
            {
                get { return blue; }
                set { blue = value; }
            }
        }
    }
}
