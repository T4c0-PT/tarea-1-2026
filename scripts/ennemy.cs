using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class ennemy : Character
    {
        public ennemy(string name, float health, float damaged)
        {
            this.name = name;
            this.health = health;
            this.damaged = damaged;
            this.isalive = true;
        }
    }
}
