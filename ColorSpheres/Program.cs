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
            
            public byte red
            {
                get { return red; }
                set { red = value; }
            }
            public byte green
            {
                get { return green; }
                set { green = value; }
            }
            public byte blue 
            {
                get { return blue; }
                set { blue = value; }
            }

            public Color(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
        }

        private class ColorSpheres
        {
            private Color color;
            private int radius;
            private int throwTimes;
        }
    }
}

