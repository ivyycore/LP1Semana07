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

        class Level
        {
            public int Level => selected + XP / 1000
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
        class MaxHealth
        {
            private float max

            public int maxhealth =>
                100 + (Level - 1) * 20
        }
        public void TakeDamage(float damage)
        {
            return Health -= float damage
            return XP += int damage 
        }
        public class Start
        {
            public int xp { get; set; } = 0;
            public float health = MaxHealth
        }
    }
}