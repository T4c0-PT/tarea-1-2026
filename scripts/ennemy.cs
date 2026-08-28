using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class ennemy
    {
        private float health, damaged;
        private bool isalive;

        public ennemy(float health, float damaged)
        {
            this.health = health;
            this.damaged = damaged;
            this.isalive = true;
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health < 0)
            {
                health = 0;
                isalive = false;
            }
        }

        public float GetDamage()
        {
            return damaged;
        }

        public bool IsAlive()
        {
            return isalive;
        }
    }
}
