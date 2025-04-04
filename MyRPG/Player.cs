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
            public string name { get; }

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
        public class Level
        {
            private readonly string level;

            public Level(int level)
            {
                this.level = 1 + XP / 1000;
            }
        } 
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                if (health < 0)
                    health = value;
                if (health > MaxHealth)
                    health = value; 
            }
        }
    }
}