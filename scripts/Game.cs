using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_2026.scripts
{
    internal class Game
    {
        private Random random = new Random();

        public void World()
        {

            Console.WriteLine("Ingrese el nombre del jugador:");

            string namePlayer = Console.ReadLine();
            player player = new player(namePlayer, 50, 10);
            Console.Clear();

            while (player.IsAlive())
            {
                string direccion = Direction();
                Console.WriteLine($"Avanzas hacia: {direccion}...");

                Room(player);

                if (!player.IsAlive())
                    break;
            }

            options gameOptions = new options();
            gameOptions.GameOver(player);

        }
    
        private string Direction()
        {
            Console.WriteLine("Elige una dirección para avanzar:");
            Console.WriteLine("1- izquierda 2- arriba  3- derecha");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    return "Izquierda";
                case "2":
                    return "Arriba";
                case "3":
                    return "Derecha";
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    return Direction();
            }
        }


        private void Room(player player)
        { 
            int RN = random.Next(1, 4);

            switch (RN)
            {
                case 1:
                    Console.WriteLine("Te encuentras en una habitación vacía.");
                    break;
                case 2:
                    List<ennemy> enemigos = new List<ennemy>();
                    int enemyR = random.Next(1, 4);
                    for (int i = 0; i < enemyR; i++)
                    {
                        if (random.Next(0, 10) < 2)
                            enemigos.Add(new tanke("Tanque", 20, 10));
                        else
                            enemigos.Add(new ennemy("Base", 20, 5));
                    }

                    Console.Clear();

                    Combat(player, enemigos);

                    break;
                case 3:
                    Console.WriteLine("Te encuentras en una habitación con un tesoro.");
                    Item[] items = new Item[]
                    {
                        new Item("Pocion de Vida", 20, 0, 0),
                        new Item("Espada Afilada", 0, 5, 0),
                        new Item("Monedas de Oro", 0, 0, 150)
                    };
                    Item encontrado = items[random.Next(items.Length)];
                    if (encontrado == items[2])
                        encontrado.Addcoins(player, encontrado.Getcoins());
                    else
                        encontrado.Apply(player);

                    break;
            }
        }

        private void Combat(player player, List<ennemy> enemigos)
        {
            foreach (var enemigo in enemigos)
            {
                while (enemigo.IsAlive() && player.IsAlive())
                {
                    Console.WriteLine($"Te encuentras en una habitación con {enemigos.Count} enemigo(s).");
                    ShowHUD(player, enemigos);
                    Console.WriteLine("el elije una opcion: 1- atacar                   2- huir");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.Clear();
                            ShowHUD(player, enemigos);
                            Console.WriteLine("¿A quien quieres atacar?");

                            for (int i = 0; i < enemigos.Count; i++)
                            {
                                if (enemigos[i].IsAlive())
                                    Console.WriteLine($"Enemigo {i}                 Vida: {enemigos[i].GetHealth()}           {enemigos[i].GetName()}");
                                else
                                    Console.WriteLine($"Enemigo {i}                 Vida:(Muerto)");
                            }


                            int seleccion = int.Parse(Console.ReadLine());

                            if (seleccion >= 0 && seleccion < enemigos.Count)
                            {
                                if (enemigos[seleccion].IsAlive())
                                {
                                    enemigos[seleccion].TakeDamage(player.GetDamage());
                                    Console.WriteLine("Acertaste el ataque");
                                }
                                else
                                    Console.WriteLine("El jugador ataco al aire (Pierdes el turno XD)");
                            }
                            else
                                Console.WriteLine("Enemigo no encontrado (Pierdes el turno XD)");

                            Console.ReadLine();
                            Console.Clear();

                            break;
                        case "2":
                            Console.WriteLine("Decides huir de la habitación.");
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                    if (enemigo.IsAlive())
                    {
                        player.TakeDamage(enemigo.GetDamage());
                        Console.WriteLine($"El enemigo te ataca y te quita {enemigo.GetDamage()} de vida.");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
            }
            if (player.IsAlive())
            {
                Console.WriteLine("¡Sala despejada! Ganas fuerza y vida. +500 monedas");
                player.AddCoins(500);
                player.LevelUp();
            }
        }


        private void ShowHUD(player player, List<ennemy> enemigos)
        {
            string[] imgEnemy = new string[]
{
                    "      @ .. . @      ",
                    "    @==@@==@@==@    ",
                    "    @=@@@==@@@*@    ",
                    "    @=@..@@..@=@    ",
                    "    %=:@@@@@@:=%    ",
                    "   *==.=@@@@=-==*   ",
                    "  @==-:++--*-:.==@  ",
                    " +*:==-@==-+@==--** ",
                    " #==--:+*%%#-=.--=# ",
                    "==-::----=:-::+-::==",
                    " @@@@========+%#@@@ ",
};

            for (int i = 0; i < imgEnemy.Length; i++)
            {
                for (int j = 0; j < enemigos.Count; j++)
                {
                    Console.Write(imgEnemy[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"======== {player.GetName()} : Nivel {player.GetLevel()} ======== Vida: {player.GetHealth()} =======");
        }
    }
}
