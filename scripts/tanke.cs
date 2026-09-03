using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class tanke : ennemy
    {
        public tanke(string name, float health, float damaged) : base(name, health, damaged){}

        public override void TakeDamage(float damage)
        {
            base.TakeDamage(damage / 2);
        }
    }
}
