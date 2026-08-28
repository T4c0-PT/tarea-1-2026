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
            Console.WriteLine("Ingrese el número de la opción deseada:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Game game = new Game();
                    game.World();
                    break;
                case "2":
                    Console.WriteLine("Saliendo del juego...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    Start();
                    break;
            }
        }

        public void HUD()
        { 
            
        
        }
    }
}
