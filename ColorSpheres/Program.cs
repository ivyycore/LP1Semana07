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

        private class Sphere
        {
            private Color color;
            private int radius;
            private int throwTimes;

            public Sphere(Color color, int radius)
            {
                this.color = color;
                this.radius = radius;
                this.throwTimes = 0;
            }

            public Color GetColor()
            {
                return color;
            }

            public int GetRadius()
            {
                return radius;
            }

            public void Pop()
            {
                radius = 0;
            }

            public void Throw()
            {
                if (radius > 0)
                {
                    throwTimes++;
                }
            }

            public int GetTimesThrown()
            {
                return throwTimes
            }
        }
        public static void Main()
        {
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255);
            Color greenColor = new Color(0, 255, 0);

            Sphere sphere1 = new Sphere(redColor, 10);
            Sphere sphere2 = new Sphere(blueColor, 15)
            Sphere sphere3 = new Sphere(greenColor, 12);
            
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();

            sphere2.Pop();

            sphere2.Throw();
        }
    }
}

