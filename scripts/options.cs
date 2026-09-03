using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class options
    {
        public void Start()
        {
            Console.WriteLine("Opciones del juego:");
            Console.WriteLine("1. Iniciar juego");
            Console.WriteLine("2. Salir");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Game game = new Game();
                    Console.Clear();
                    game.World();
                    break;
                case "2":
                    Console.WriteLine("Saliendo del juego...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");              
                    Start();
                    break;
            }
        }


        public void GameOver(player player)
        {
            Console.WriteLine("Game Over \nScore: ");
            Console.WriteLine($"Nombre del jugador: {player.GetName()} Level: {player.GetLevel()} Coins: {player.Getcoins()}\n");
            Console.WriteLine("1. Reiniciar juego");
            Console.WriteLine("2. Salir");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Start();
                    break;
                case "2":
                    Console.WriteLine("Saliendo del juego...");
                    break; 
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    GameOver(player);
                    break;
            }
        }
    }
}
