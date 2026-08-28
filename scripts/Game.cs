using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class Game
    {
        public void World()
        {
            Console.WriteLine("Ingrese el nombre del jugador:");

            string namePlayer = Console.ReadLine();
            player jugador = new player(namePlayer, 50, 10);
            Console.Clear();


        }

    }
}
