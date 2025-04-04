using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRPG
{
    public class Player
    {
        public int xp { get; }
        public float health { get; }

        public class Name
        {
            private readonly string name;

            public Name(string name)
            {
                this.name = name;
            }
        }
        public int XP
        {
            get
            {
                return xp;
            }
            set
            {
                xp = value;
                if (xp < value)
                    return xp; 
            }
        }
        private readonly string name;

        public Level(int level)
        {
            this.level = 1 + XP / 1000;
        }
    }
}