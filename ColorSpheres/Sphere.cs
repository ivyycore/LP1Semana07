using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
        public class Sphere
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
                return throwTimes;
            }
        }
}