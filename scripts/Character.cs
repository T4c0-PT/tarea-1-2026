using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class Character
    {
        protected float health, damaged;
        protected bool isalive;

        protected string name;


        public virtual void TakeDamage(float damage)
        {
            health -= damage;
            if (health <= 0)
            {
                health = 0;
                isalive = false;
            }
        }

        public float GetDamage() { return damaged; }
        public float GetHealth() { return health; }
        public bool IsAlive() { return isalive; }

        public string GetName() { return name; }
    }
}
