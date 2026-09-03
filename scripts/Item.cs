using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class Item
    {
        private string name;
        private int extraHealth, extraDamage, coins;

        public Item(string name, int extraHealth, int extraDamage, int coins)
        {
            this.name = name;
            this.extraHealth = extraHealth;
            this.extraDamage = extraDamage;
            this.coins = coins;
        }

        public void Apply(player player)
        {
            player.AddHealth(extraHealth);
            player.AddDamage(extraDamage);
            Console.WriteLine($"Item {name} aplicado: +{extraHealth} salud, +{extraDamage} daño, +{coins} monedas.");
        }

        public void Addcoins(player player, int amount)
        {
            player.AddCoins(amount);
            Console.WriteLine("Monedas añadidas: " + amount);
        }

        public int Getcoins() { return coins; }
    }
}
