using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class player
    {
        private string name;
        private float health, damaged;
        private bool isalive;
        private int level;

        public player(string name, float health , float damaged)
        {
            this.name = name;
            this.health = health;
            this.damaged = damaged;
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health < 0)
            {
                health = 0;
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
