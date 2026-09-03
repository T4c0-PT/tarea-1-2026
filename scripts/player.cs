using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class player : Character
    {
        private int level , coins;

        public player(string name, float health , float damaged)
        {
            this.name = name;
            this.health = health;
            this.damaged = damaged;
            this.isalive = true;
            this.level = 1;
            this.coins = 0;
        }

        public float GetLevel() { return level; }
        public void AddHealth(float amount){health += amount;}
        public void AddDamage(float amount) { damaged += amount; }
        public void AddCoins(int amount) { coins += amount; }
        public int Getcoins() { return coins; }

        public void LevelUp()
        {
            level++;
            health += 10;
            damaged += 2;
        }



    }
}
