using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        //Construtor
        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        
        }

        public string GetName ()
        {
            return name;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield<0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health<0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public string SetName(string name)
        {
            const int MaxLength = 8;
            if (name.Length > MaxLength)
            name = name.Substring(0,MaxLength);
            return name;
        }
    }
}