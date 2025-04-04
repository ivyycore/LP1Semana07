using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
public class Sphere
    {
        public Color Color { get; } 
        public int Radius { get; private set; } 
        private int ThrowTimes;

        //Propriedades 
        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            ThrowTimes = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                ThrowTimes++;
            }
        }
            public int GetTimesThrown() => ThrowTimes;
    }
}